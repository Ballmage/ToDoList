using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Services
{
    class FileIOService
    {
        private readonly string path;


        public FileIOService(string path )
        {
            this.path = path;
        }
        public BindingList<ToDoModels> LoadData()
        {
            return null;
        }

        public void SaveData(BindingList<ToDoModels> todoDataList)
        {
            using (StreamWriter writer = File.CreateText(path))
            {
                string output = JsonConvert.SerializeObject(todoDataList);
                writer.Write(output);
            }
        }
    }
}
