using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.IO;
using System.Text; 
using System.Text.RegularExpressions;

namespace FlowRun
{
    class Run1
    {
        string d;
        string key;
        Dictionary<string, string> myDic = new Dictionary<string, string>();

        public  Dictionary<string, string> Read(string path) //读txt文件 返回字典
        {
            StreamReader sr = new StreamReader(path,Encoding.Default);
            String line;
            String[] dic_ori;
            var dic = new Dictionary<string, string>();
            if((line = sr.ReadLine()) != null) 
            {
            }
            while ((line = sr.ReadLine()) != null) 
            {
                dic_ori = line.Split(':'); //将一行用,分开成键值对
                dic.Add(dic_ori[1],dic_ori[2]);
            }
            return dic;
        }
         
        //public void Write(string path, Dictionary<string, string> mydic) //将字典写入txt
        //{
        //    FileStream fs = new FileStream(path, FileMode.Create);
        //    StreamWriter sw = new StreamWriter(fs);
        //    //开始写入
        //    foreach(var d in mydic)
        //    {
        //         sw.Write(d.Keys,+','+d.value); //键值对写入，用逗号隔开
        //    }
        //    //清空缓冲区
        //    sw.Flush();
        //    //关闭流
        //    sw.Close();
        //    fs.Close();
        //}
    }
}
