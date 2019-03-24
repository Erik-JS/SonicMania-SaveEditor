using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicMania_SaveEditor
{
    class Savedata
    {
        public static byte[] Content;

        public static bool IsLittleEndian;

        public static bool LoadFromFile(string file, bool isPCversion)
        {
            try
            {
                byte[] fileContent = File.ReadAllBytes(file);
                if (fileContent.Length != 0x10000)
                {
                    MessageBox.Show("Incorrect file size.", "LoadFromFile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                Content = fileContent;
                IsLittleEndian = isPCversion;
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.GetType().Name + "\n" + ex.Message, "LoadFromFile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool SaveToFile(string file)
        {
            try
            {
                File.WriteAllBytes(file, Content);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().Name + "\n" + ex.Message, "SaveToFile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static int GetInt32(int location)
        {
            int response = BitConverter.ToInt32(Content, location);
            if (IsLittleEndian)
                return response;
            byte[] tempArray = BitConverter.GetBytes(response);
            Array.Reverse(tempArray);
            return BitConverter.ToInt32(tempArray, 0);
        }

        public static void SetInt32(int location, int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            if (!IsLittleEndian)
                Array.Reverse(bytes);
            Array.Copy(bytes, 0, Content, location, 4);
        }

        public static int GetSlotState(int slot)
        {
            return GetInt32((0x400 * slot) + 0x58);
        }

        public static void SetSlotState(int slot, int state)
        {
            SetInt32((0x400 * slot) + 0x58, state);
        }

        public static int GetPlayableCharacter(int slot)
        {
            return GetInt32((0x400 * slot) + 0x5C);
        }
        public static void SetPlayableCharacter(int slot, int value)
        {
            SetInt32((0x400 * slot) + 0x5C, value);
        }

        public static int GetZone(int slot)
        {
            return GetInt32((0x400 * slot) + 0x60);
        }
        public static void SetZone(int slot, int value)
        {
            SetInt32((0x400 * slot) + 0x60, value);
        }

        public static int GetLivesCount(int slot)
        {
            return GetInt32((0x400 * slot) + 0x64);
        }
        public static void SetLivesCount(int slot, int value)
        {
            SetInt32((0x400 * slot) + 0x64, value);
        }

        public static int GetScore(int slot)
        {
            return GetInt32((0x400 * slot) + 0x68);
        }
        public static void SetScore(int slot, int value)
        {
            SetInt32((0x400 * slot) + 0x68, value);
        }

        public static int GetTargetScore(int slot)
        {
            return GetInt32((0x400 * slot) + 0x6C);
        }
        public static void SetTargetScore(int slot, int value)
        {
            SetInt32((0x400 * slot) + 0x6C, value);
        }

        public static bool IsEmeraldActive(int slot, int emerald)
        {
            byte emeralds = Content[(0x400 * slot) + 0x70];
            int emeraldActive = 1 << emerald;
            return (emeralds & emeraldActive) != 0;
        }
        public static void SetEmeraldState(int slot, int emerald, bool isActive)
        {
            int emeraldActive = 1 << emerald;
            if (isActive)
                Content[(0x400 * slot) + 0x70] |= (byte)emeraldActive;
            else
                Content[(0x400 * slot) + 0x70] &= (byte)~(emeraldActive);
        }

        public static int GetContinues(int slot)
        {
            return GetInt32((0x400 * slot) + 0x74);
        }
        public static void SetContinues(int slot, int value)
        {
            SetInt32((0x400 * slot) + 0x74, value);
        }

        public static int GetNextSpecialStage(int slot)
        {
            return GetInt32((0x400 * slot) + 0x7C);
        }
        public static void SetNextSpecialStage(int slot, int value)
        {
            SetInt32((0x400 * slot) + 0x7C, value);
        }

        public static void ResetGiantRingsForCurrentZone(int slot)
        {
            SetInt32((0x400 * slot) + 0x80, 0);
        }
        public static bool WasGiantRingUsedInCurrentZone(int slot)
        {
            return GetInt32((0x400 * slot) + 0x80) != 0;
        }

        public static int[] GetEncoreCharacters(int slot)
        {
            byte[] characters = new byte[5];
            uint backrowchar = (uint)GetInt32((0x400 * slot) + 0x10C);
            uint frontrowchar = (uint)GetInt32((0x400 * slot) + 0x110);
            characters[0] = (byte)frontrowchar;
            characters[1] = (byte)(frontrowchar >> 8);
            characters[2] = (byte)backrowchar;
            characters[3] = (byte)(backrowchar >> 8);
            characters[4] = (byte)(backrowchar >> 16);
            List<int> lstRes = new List<int>();
            foreach (var b in characters)
            {
                lstRes.Add(GetEncoreCharacterInt(b));
            }
            return lstRes.ToArray();
        }
        private static int GetEncoreCharacterInt(byte b)
        {
            int res = 0;
            while (b > 1)
            {
                b /= 2;
                res++;
            }
            res += b;
            return res;
        }
        public static void SetEncoreCharacters(int slot, int[] values)
        {
            byte[] bValues = new byte[5];
            for (int i = 0; i < bValues.Length; i++)
            {
                bValues[i] = (values[i] == 0) ? (byte)0 : (byte)Math.Pow(2, values[i] - 1);
            }
            int backrowvalue = bValues[2] + bValues[3] * 256 + bValues[4] * 65536;
            int frontrowvalue = bValues[0] + bValues[1] * 256;
            SetInt32((0x400 * slot) + 0x10C, backrowvalue);
            SetInt32((0x400 * slot) + 0x110, frontrowvalue);
            int availablecharacters = 0;
            foreach (var b in bValues)
                availablecharacters |= b;
            SetInt32((0x400 * slot) + 0x108, availablecharacters);
        }

        public static int GetSilverMedalCount()
        {
            return GetInt32(0x2520);
        }
        public static int GetGoldMedalCount()
        {
            return GetInt32(0x251C);
        }
        public static void SetSilverMedalCount(int value)
        {
            SetInt32(0x2520, value);
        }
        public static void SetGoldMedalCount(int value)
        {
            SetInt32(0x251C, value);
        }

        public static int GetBonusStageStatus(int stage)
        {
            return Content[0x2456 + stage];
        }
        public static void SetBonusStageStatus(int stage, int status)
        {
            Content[0x2456 + stage] = (byte)status;
        }
        public static void SetBonusStageStatusAll(int status)
        {
            for (int i = 0; i < 32; i++)
            {
                SetBonusStageStatus(i, status);
            }
        }

        public static int CalculateGoldMedals()
        {
            int count = 0;
            for (int x = 0; x < 32; x++)
            {
                count += (GetBonusStageStatus(x) == 2) ? 1 : 0;
            }
            return count;
        }
        public static int CalculateSilverMedals()
        {
            int count = 0;
            for (int x = 0; x < 32; x++)
            {
                count += (GetBonusStageStatus(x) != 0) ? 1 : 0;
            }
            return count;
        }


    }
}
