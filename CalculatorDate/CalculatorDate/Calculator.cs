using System;

namespace CalculatorDate
{
    class Calculator
    {
        private DateTime date1;
        private DateTime date2;

        private String strdate1;
        private String strdate2;

        public Calculator(String strdate1, String strdate2)
        {
            this.strdate1 = strdate1;
            this.strdate2 = strdate2;
        }

        private bool Validate(String strdate, ref DateTime D, ref String err)
        {
            String[] a;
            if (strdate.IndexOf(".") != -1)
            {
                //Россия
                a = strdate.Split(new Char[] { '.' });
                if (a.Length != 3) return false;
                int dd;
                int.TryParse(a[0], out dd);
                int mm;
                int.TryParse(a[1], out mm);
                int yyyy;
                int.TryParse(a[2], out yyyy);

                try
                {
                    D = new DateTime(yyyy, mm, dd);
                }
                catch (ArgumentOutOfRangeException outOfRange)
                {
                    err = outOfRange.Message;
                    return false;
                }
                return true;
            }

            if (strdate.IndexOf("-") != -1)
            {
                //США
                a = strdate.Split(new Char[] { '-' });
                if (a.Length != 3) return false;
                int mm;
                int.TryParse(a[0], out mm);
                int dd;
                int.TryParse(a[1], out dd);
                int yyyy;
                int.TryParse(a[2], out yyyy);

                try
                {
                    D = new DateTime(yyyy, mm, dd);
                }
                catch (ArgumentOutOfRangeException outOfRange)
                {
                    err = outOfRange.Message;
                    return false;
                }
                return true;
            }

            if (strdate.IndexOf("/") != -1)
            {
                //Великобритания
                a = strdate.Split(new Char[] { '/' });
                if (a.Length != 3) return false;
                int dd;
                int.TryParse(a[0], out dd);
                int mm;
                int.TryParse(a[1], out mm);
                int yyyy;
                int.TryParse(a[2], out yyyy);

                try
                {
                    D = new DateTime(yyyy, mm, dd);
                }
                catch (ArgumentOutOfRangeException outOfRange)
                {
                    err = outOfRange.Message;
                    return false;
                }
                return true;
            }
            return false;
        }

        public int countMonths(ref String err1, ref String err2)
        {
            if (!AllValidate(ref err1, ref err2)) return -1;
            if (date1 > date2)
            {
                return (date1.Year - date2.Year) * 12 + date1.Month - date2.Month;
            }
            else
            {
                return (date2.Year - date1.Year) * 12 + date2.Month - date1.Month;
            }
        }

        public int countWeeks(ref String err1, ref String err2)
        {
            if (!AllValidate(ref err1, ref err2)) return -1;
            if (date1 > date2)
            {
                return (int)(date1 - date2).TotalDays / 7;
            }
            else
            {
                return (int)(date2 - date1).TotalDays / 7;
            }
        }

        public int countDays(ref String err1, ref String err2)
        {
            if (!AllValidate(ref err1, ref err2)) return -1;
            if (date1 > date2)
            {
                return (int)(date1 - date2).TotalDays;
            }
            else
            {
                return (int)(date2 - date1).TotalDays;
            }
        }

        public int countHours(ref String err1, ref String err2)
        {
            if (!AllValidate(ref err1, ref err2)) return -1;
            if (date1 > date2)
            {
                return (int)(date1 - date2).TotalDays * 24;
            }
            else
            {
                return (int)(date2 - date1).TotalDays * 24;
            }
        }

        public long countMinutes(ref String err1, ref String err2)
        {
            if (!AllValidate(ref err1, ref err2)) return -1;
            if (date1 > date2)
            {
                return (long)(date1 - date2).TotalDays * 24 * 60;
            }
            else
            {
                return (long)(date2 - date1).TotalDays * 24 * 60;
            }
        }

        public long countSeconds(ref String err1, ref String err2)
        {
            if (!AllValidate(ref err1, ref err2)) return -1;
            if (date1 > date2)
            {
                return (long)(date1 - date2).TotalDays * 24 * 60 * 60;
            }
            else
            {
                return (long)(date2 - date1).TotalDays * 24 * 60 * 60;
            }
        }

        public bool AllValidate(ref String err1, ref String err2)
        {
            return Validate(strdate1, ref date1, ref err1) && Validate(strdate2, ref date2, ref err2);
        }
    }
}
