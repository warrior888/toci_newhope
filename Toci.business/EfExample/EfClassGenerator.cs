﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Toci.business.EfExample
{
    public class EfClassGenerator
    {
        TypeTranslator ttr = new TypeTranslator();

        public virtual string ReadDdl()
        {
            FileStream fs = new FileStream(@"C:\Users\Administrator\Documents\toci_newhope\sql.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.ASCII);

            return sr.ReadToEnd();
        }

        public virtual string[] Cut(string fContent, string delimiter)
        {
            return fContent.Split(new string[] {delimiter}, StringSplitOptions.None);


        }

        protected virtual List<string[]> CutArray(string[] elements, string delimiter)
        {
            List<string[]> result = new List<string[]>();
            foreach (var item in elements)
            {
                result.Add(Cut(item, delimiter));
            }

            return result;
        }

        public virtual List<string> GenerateCode()
        {
            string ddl = ReadDdl();
            string[] creates = Cut(ddl, ";");

            for (int i =0; i < creates.Length; i++)
            {
                if (creates[i].IndexOf("(") > -1)
                {
                    creates[i] = creates[i].Substring(creates[i].IndexOf("(") + 1,
                        creates[i].LastIndexOf(")") - creates[i].IndexOf("(") - 1);
                }
            }

            List<string[]> columns = CutArray(creates, ",");
            List<List<string[]>> columnDefinitions = new List<List<string[]>>();
            foreach (var columnSet in columns)
            {
                if (columnSet.Length > 0)
                {
                    columnDefinitions.Add(CutArray(columnSet, " "));
                }
            }

            List<string> entities = new List<string>();

            foreach (var cDef in columnDefinitions)
            {
                entities.Add(GetCode(cDef));
            }

            return entities;
        }

        protected virtual string GetCode(List<string[]> columns)
        {
            string pattern = "public {0} {1} ;" + Environment.NewLine;
            string result = "";

            foreach (var column in columns)
            {
                if (column.Length > 5)
                {
                    result += string.Format(pattern, ttr.GetCSharpTypeForDbType(column[5].Trim()), column[4]);
                }
            }

            return result;
        }
    }
}