using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace تکلیف_5
{
    internal class ClsStudent
    {
        private string _Fname = string.Empty;
        private string _Lname = string.Empty;
        private Int64 _IDnumber;
        private double _Grade;



        public string Fname
        {
            get { return _Fname; }
            set { _Fname = value.Trim(); }
        }
        public string Lname
        {
            get { return _Lname; }
            set { _Lname = value.Trim(); }
        }
        public Int64 IDnumber
        {
            get { return _IDnumber; }
            set { _IDnumber = value; }
        }
        public double Grade
        {
            get { return _Grade; }
            set { _Grade = value; }
        }


    }
}
