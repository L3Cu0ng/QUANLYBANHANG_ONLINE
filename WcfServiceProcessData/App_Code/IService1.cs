using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
namespace WcfServiceProcessData
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        DataSet getTableProcedurce(String nameprocedurce,
            Dictionary<String, object> values);
        [OperationContract]
        DataSet getTable(String SQL);
        [OperationContract]
        int ExeCuteSQL(string SQL);
        [OperationContract]
        int ExeCuteProcedurce(String nameprocedurce,
            Dictionary<String, object> values);
    }

}