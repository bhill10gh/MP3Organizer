using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.XPath;

using BCHFramework;

namespace DAL
{
    public class SqlScriptParameter
    {
        public SqlScriptParameterTypeEnum Type { get; set; }

        public string Marker { get; set; }

        public string Value { get; set; }
    }

    public enum SqlScriptParameterTypeEnum
    {
        Integer,
        Decimal,
        String
    }

    public class SqlScriptMembers
	{

        public Dictionary<string, SqlScriptParameter> Parameters { get; set; }

        public string Sql { get; set; }

        public string Type { get; set; }
	}

    public class SqlScripts
    {
        public Dictionary<string,SqlScriptMembers> SqlScriptDict { get; private set; }

        public XmlDocument XmlDoc { get; private set; }

        public bool IsSet { get; private set; }

        private List<string> SSTypeList
        { 
            get
            {
                List<string> list = new List<string>();
                list.Add(SqlScriptParameterTypeEnum.Decimal.ToString());
                list.Add(SqlScriptParameterTypeEnum.Integer.ToString());
                list.Add(SqlScriptParameterTypeEnum.String.ToString());

                return list;
            }
        }

        public SqlScripts()
        {
            this.XmlDoc = new XmlDocument();
            this.SqlScriptDict = new Dictionary<string, SqlScriptMembers>();
            this.IsSet = false;
        }

        public void Load(string xmlFileName, ref OperationResult op)
        {

            try
            {
                this.XmlDoc = new XmlDocument();
                this.XmlDoc.Load(xmlFileName);
                XmlNodeList scriptList = XmlDoc.SelectNodes("/SqlScripts/SqlScript");

                foreach (XmlElement script in scriptList)
                {
                    string name = script.SelectSingleNode("Name").InnerText.Trim();
                    string sql = script.SelectSingleNode("Sql").InnerText;
                    string type = script.SelectSingleNode("Type").InnerText;
                    XmlNodeList paramList = script.SelectNodes("Parameters/Parameter");
                    SqlScriptMembers sm = new SqlScriptMembers();
                    sm.Parameters = new Dictionary<string, SqlScriptParameter>();
                    foreach (XmlElement param in paramList)
                    {
                        string pName = param.GetAttribute("name").Trim();
                        string pType = param.GetAttribute("type").Trim();
                        string pMarker = param.InnerText;
                        SqlScriptParameter ssp = new SqlScriptParameter();

                        ssp.Type = GetParamType(pType);
                        ssp.Marker = pMarker;
                        
                        sm.Parameters.Add(pName, ssp);                        
                    }
                    sm.Sql = sql;
                    if(sm.Sql.Trim().Length > 1 && name.Trim().Length > 1)
                    {
                        this.SqlScriptDict.Add(name, sm);
                    }
                    sm.Type = type;
                }
                if (SqlScriptDict == null || SqlScriptDict.Count < 1)
                {
                    op.AddError("Sql Scripts not set.  Make sure there are valid scripts.");
                    this.IsSet = false;
                    return;
                }

                this.IsSet = true;
            }
            catch (Exception ex)
            {
                
                op.AddException(ex);
            }
        }

        private SqlScriptParameterTypeEnum GetParamType(string type)
        {
            if(string.IsNullOrEmpty(type) || !SSTypeList.Contains(type, StringComparer.InvariantCultureIgnoreCase))
            {
                return SqlScriptParameterTypeEnum.String;
            }

            if(type.Trim().ToUpper() == SqlScriptParameterTypeEnum.Decimal.ToString().ToUpper())
            {
                return SqlScriptParameterTypeEnum.Decimal;
            }

            if (type.Trim().ToUpper() == SqlScriptParameterTypeEnum.Integer.ToString().ToUpper())
            {
                return SqlScriptParameterTypeEnum.Integer;
            }

            return SqlScriptParameterTypeEnum.String;

        }
    }
}
