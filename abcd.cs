using System;
using System.Threading;
using System.Threading.Tasks;
class abcd{
    public static void Main(string[] args){
        start1:
        int h,m,s;
        int d=1000;
        Console.WriteLine("Set time:");
        h=Convert.ToInt32(Console.ReadLine());
        m=Convert.ToInt32(Console.ReadLine());
        s=Convert.ToInt32(Console.ReadLine());
        if(h>12|| m>60 || s>60){
            Console.WriteLine("Invalid time");
            goto start1;
        }
        
        while(true){
            s++;
            if(s>59){
                m++;
                if(m>59){
                    h++;
                    m=0;
		    if(h>12){h=1;}
                }
                s=0;
            }
	    Console.Clear();
            Console.WriteLine("Time: "+h+" : "+m+" : "+s);
            Thread.Sleep(d);

        }
    }
}