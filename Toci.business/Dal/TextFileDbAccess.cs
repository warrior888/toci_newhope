using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace Toci.business.Dal
{
    public class TextFileDbAccess : DbAccessBase<string>
    {
        protected FileStream Fs;
        protected StreamReader Sr;

        public override bool Connect(string connectionString)
        {
            Fs = new FileStream(connectionString, FileMode.Open); //@"C:\Users\Administrator\Desktop"

            return true;

            //Sr.ReadToEnd(new FileStream())
        }

        public override int ExecuteInsert(string query)
        {
            throw new System.NotImplementedException();
        }

        public override string ExecuteSelect(string @select)
        {
            return Sr.ReadToEnd();//.Split(new[] { "\n" }, StringSplitOptions.None).ToList();
        }
    }
}