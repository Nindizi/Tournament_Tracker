using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        // TODO - make the CreatePrize method actually save to the database
        /// <summary>
        /// Saves a new prize to the database 
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The prize information, including the uinque identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            //prep for using sql database
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {

            }

            return model;
        }
    }
}
