namespace Exercise01.Functions
{
    public static class NumToWordsFunction
    {
        public static string GetOnes(string Number)
        {
            var Ones = (Ones)Convert.ToInt32(Number);
            return Ones.ToString();
        }
        public static string GetTens(string Number)
        {
            try
            {
                Tens TensEnumValue = (Tens)Convert.ToInt32(Number);
                Tens TensValue = new();
                TensValue = (Tens)Convert.ToInt32(Number);
                string ReturnValue = string.Empty;
                switch (TensValue)
                {
                    case Tens.Ten:
                        ReturnValue = TensEnumValue.ToString(); break;
                    case Tens.Eleven:
                        ReturnValue = TensEnumValue.ToString(); break;
                    case Tens.Twelve:
                        ReturnValue = TensEnumValue.ToString(); break;
                    case Tens.Thirteen:
                        ReturnValue = TensEnumValue.ToString(); break;
                    case Tens.Fourteen:
                        ReturnValue = TensEnumValue.ToString(); break;
                    case Tens.Fifteen:
                        ReturnValue = TensEnumValue.ToString(); break;
                    case Tens.Sixteen:
                        ReturnValue = TensEnumValue.ToString(); break;
                    case Tens.Seventeen:
                        ReturnValue = TensEnumValue.ToString(); break;
                    case Tens.Eighteen:
                        ReturnValue = TensEnumValue.ToString(); break;
                    case Tens.Nineteen:
                        ReturnValue = TensEnumValue.ToString(); break;
                    case Tens.Twenty:
                        ReturnValue = TensEnumValue.ToString(); break;
                    case Tens.Thirty:
                        ReturnValue = TensEnumValue.ToString(); break;
                    case Tens.Fourty:
                        ReturnValue = TensEnumValue.ToString(); break;
                    case Tens.Fifty:
                        ReturnValue = TensEnumValue.ToString(); break;
                    case Tens.Sixty:
                        ReturnValue = TensEnumValue.ToString(); break;
                    case Tens.Seventy:
                        ReturnValue = TensEnumValue.ToString(); break;
                    case Tens.Eighty:
                        ReturnValue = TensEnumValue.ToString(); break;
                    case Tens.Ninety:
                        ReturnValue = TensEnumValue.ToString(); break;
                    default:
                        if (TensValue > 0)
                        {
                            ReturnValue = GetTens(string.Concat(Number.AsSpan(0, 1), "0")) + " " + GetOnes(Number[1..]);
                        }
                        break;
                }
                return ReturnValue;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static string WholeNumber(string Number)
        {
            string ReturnValue = string.Empty;
            try
            {
                bool Done = false;
                double dblAmt = (Convert.ToDouble(Number));
                if (dblAmt > 0)
                {
                    int Length = Number.Length;
                    int Index = 0;
                    string NumberName = string.Empty;
                    switch (Length)
                    {
                        case 1:

                            ReturnValue = GetOnes(Number);
                            Done = true;
                            break;
                        case 2:
                            ReturnValue = GetTens(Number);
                            Done = true;
                            break;
                        case 3:
                            Index = (Length % 3);
                            NumberName = " Hundred And ";
                            break;
                        case 4:
                        case 5:
                        case 6:
                            Index = (Length % 4);
                            NumberName = " Thousand ";
                            break;
                        case 7:
                        case 8:
                        case 9:
                            Index = (Length % 7);
                            NumberName = " Million ";
                            break;
                        case 10:
                        case 11:
                        case 12:

                            Index = (Length % 10);
                            NumberName = " Billion ";
                            break;
                        case 13:
                        case 14:
                        case 15:

                            Index = (Length % 13);
                            NumberName = " Trillion ";
                            break;
                        case 16:
                        case 17:
                        case 18:

                            Index = (Length % 16);
                            NumberName = " Quadrillion ";
                            break;
                        case 19:
                        case 20:
                        case 21:

                            Index = (Length % 19);
                            NumberName = " Quintillion ";
                            break;
                        default:
                            Done = true;
                            break;
                    }
                    if (!Done)
                    {
                        Index++;
                        if (Number[..Index] != "0" && Number[Index..] != "0")
                        {
                            try
                            {
                                ReturnValue = WholeNumber(Number[..Index]) + NumberName + WholeNumber(Number[Index..]);
                            }
                            catch { }
                        }
                        else
                        {
                            ReturnValue = WholeNumber(Number[..Index]) + WholeNumber(Number[Index..]);
                        }
                    }
                    if (ReturnValue.Trim().Equals(NumberName.Trim())) ReturnValue = "";
                }
            }
            catch { }
            return ReturnValue.Trim();
        }
        public enum Ones
        {
            Zero,
            One,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine
        }
        public enum Tens
        {
            Ten = 10,
            Eleven = 11,
            Twelve = 12,
            Thirteen = 13,
            Fourteen = 14,
            Fifteen = 15,
            Sixteen = 16,
            Seventeen = 17,
            Eighteen = 18,
            Nineteen = 19,
            Twenty = 20,
            Thirty = 30,
            Fourty = 40,
            Fifty = 50,
            Sixty = 60,
            Seventy = 70,
            Eighty = 80,
            Ninety = 90
        }
    }
}
