using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version2
{
    public class DataStorage
    {
        // The list you want to share
        public List<string> SharedList { get; set; }

        // Singleton pattern to ensure a single instance of the class
        private static DataStorage _instance;

        public static DataStorage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataStorage();
                    _instance.SharedList = new List<string>();
                }
                return _instance;
            }
        }
    }

}
