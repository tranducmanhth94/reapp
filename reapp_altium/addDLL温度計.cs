using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace reapp_altium
{
     public class addDLL温度計
    {
        [DllImport("TdTr73UCom.dll", CharSet = CharSet.Unicode)]
        public static extern int TdTr73UCom_IsConnect();
       
        [DllImport("TdTr73UCom.dll", CharSet = CharSet.Unicode)]
        public static extern int TdTr73UCom_GetCurrent();


        //nt TdTr73UCom_GetConctMachInfo(DWORD no, DWORD& serialNo, WORD& macCode, char* macName,ULONG timeOut=DEF_TIMEOUT1) 
        [DllImport("TdTr73UCom.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int TdTr73UCom_GetConctMachInfo(uint no, ref uint serialNo, ref short macCode, StringBuilder macName, uint DEF_TIMEOUT1 = 2);


        //int TdTr73UCom_GetCurrent(DWORD sNo, WORD& ch1Data, WORD& ch2Data, WORD& ch3Data, ULONG timeout = DEF_TIMEOUT1) 
        [DllImport("TdTr73UCom.dll", CallingConvention = CallingConvention.StdCall)]

        public static extern int TdTr73UCom_GetCurrent(uint no, ref uint ch1Data, ref uint ch2Data, ref uint ch3Data, uint DEF_TIMEOUT1 = 2);


        //int TdTr73UCom_StartRec(DWORD sNo,ULONG timeOut = DEF_TIMEOUT1)
        [DllImport("TdTr73UCom.dll", CharSet = CharSet.Unicode)]
        public static extern int TdTr73UCom_StartRec(uint no, uint DEF_TIMEOUT1 = 2);
    }
}
