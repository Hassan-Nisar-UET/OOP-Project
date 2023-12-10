using System;
using System.Collections;

namespace finalproject2.c
{
    static class List
    {
        public static ArrayList allWorkers = new ArrayList();
        public static ArrayList allProducts = new ArrayList();
        public static ArrayList allMsg = new ArrayList();
    }

    public class message
    {
      
    }

    class start
    {
        public string customerName = "";
        int value = 0;
        int option = -5;
        int manueOption = -5;
        int adminOption = 0;
        public void manue1()
        {
            while (option != 4)
            {
                manue0();
                Console.WriteLine("enter your option");
                value = Convert.ToInt32(Console.ReadLine());
                setValue(value);
                option = Convert.ToInt32(getValue());
                Console.Clear();

                if (option == 1)
                {
                    string adminName = "";
                    int adminPin = 0;

                    Console.WriteLine("enter the name of admin");
                    adminName = Console.ReadLine();

                    Console.WriteLine("enter the password");
                    adminPin = Convert.ToInt32(Console.ReadLine());

                    workers w2 = new workers(adminName, adminPin);
                }
                if (option == 2)
                {
                    string managerName = "";
                    int managerPin = 0;

                    Console.WriteLine("enter the name of manager");
                    managerName = Console.ReadLine();

                    Console.WriteLine("enter the password");
                    managerPin = Convert.ToInt32(Console.ReadLine());

                    manager m = new manager(managerName, managerPin);
                }
                if (option == 3)
                {

                    Console.WriteLine("enter the name of customer");
                    customerName = Console.ReadLine();
                    shop c1 = new shop(customerName);





                }
            }
        }
        
        public void getValueFunction()
        {
            Console.WriteLine("enter the option");
            adminOption = Convert.ToInt32(Console.ReadLine());
        }
        public int setValueFunction()
        {
            return adminOption;
        }
        public void setValue(int value)
        {
            manueOption = value;
        }
        public int getValue()
        {
            return manueOption;
        }
        public void showProductDetail()
        {
            for (int i = 0; i < List.allProducts.Count; i++)
            {
                manager product_all = (manager)List.allProducts[i];

                Console.WriteLine("product Name : " + product_all.pName);
                Console.WriteLine("product quantity       : " + product_all.pQuantity);
                Console.WriteLine("product price        : " + product_all.pPrice);

            }
        }
        public void showWorkersDetail()
        {
            for (int i = 0; i < List.allWorkers.Count; i++)
            {
                workers worker_all = (workers)List.allWorkers[i];
                Console.WriteLine("worker Name : " + worker_all.wName);
                Console.WriteLine("age        : " + worker_all.wAge);
                Console.WriteLine("experience        : " + worker_all.wExp);
            }
        }

        public void manue2()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("|         WELCOM TO ADMIN SECTION               |");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("1. Admin can add workers detail");
            Console.WriteLine("2. admin can view the workers details.");
            Console.WriteLine("3. Admin can change workers detail");
            Console.WriteLine("4. Admin can view product");
            Console.WriteLine("5. Admin can send message to manager");
            Console.WriteLine("6. Admin can view message of manager");
            Console.WriteLine("7. Exit");
        }
        public void manue3()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("|         WELCOM TO MANAGER SECTION             |");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("1. add paints details");
            Console.WriteLine("2. view paint details");
            Console.WriteLine("3. change paint details");
            Console.WriteLine("4. send message to Admin");
            Console.WriteLine("5. view message of Admin");
            Console.WriteLine("6. send message to customer");
            Console.WriteLine("7. view message of customer");
            Console.WriteLine("8. Exit");
        }
        public void manue4()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("|         WELCOM TO CUSTOMER SECTION            |");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("1.view the stocks");
            Console.WriteLine("2.buy paint");
            Console.WriteLine("3.view the verity of paints");
            Console.WriteLine("4.send message to manager");
            Console.WriteLine("5.view message of manager");
            Console.WriteLine("6.exit");
        }

        public void manue6()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("|         WELCOM TO CUSTOMER SECTION            |");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("1.view the stocks");
            Console.WriteLine("2.buy paint");
            Console.WriteLine("3.view the verity of paints");
            Console.WriteLine("4.send message to manager");
            Console.WriteLine("5.view message of manager");
            Console.WriteLine("6.exit");
        }
        public void manue0()
        {
            Console.WriteLine(" 1:Login as Admin");
            Console.WriteLine(" 2:Login as manager");
            Console.WriteLine(" 3:customer");
            Console.WriteLine(" 4:Exit");
        }
        string msgA="";
        string msg1="";
        public void sendMsg(){
            Console.WriteLine("type message for manager");
            msgA =Console.ReadLine();
            addMsg( msgA);
        }
        public void addMsg(string msgA)
        {
            start mFM = new start(msgA);
            List.allMsg.Add(mFM);
        }
        public start(string msgA)
        {
            this.msg1 = msgA;
            
        }
        public start(){

        }
          public void showMsgOfAdmin()
        {
            for (int i = 0; i < List.allMsg.Count; i++)
            {
                start msg_all = (start)List.allMsg[i];
                Console.WriteLine("message of admin " + msg_all.msg1);
                
            }
        }
        string msgB="";
        string msg2="";
        int a=0;
        int aa=0;
        public void sendMsgtoAdmin(){
            Console.WriteLine("type message for manager");
            msgB =Console.ReadLine();
            addMsgForAdmin( msgB,a);
        }
        public void addMsgForAdmin(string msgB,int a)
        {
            start mFA = new start(msgB,a);
            List.allMsg.Add(mFA);
        }
        public start(string msgB,int a)
        {
            this.msg2 = msgB;
            this.aa=a;
        }

        
          public void showMsgOfManager()
        {
            for (int i = 0; i < List.allMsg.Count; i++)
            {
                start msgs_all = (start)List.allMsg[i];
                Console.WriteLine("message of managr : " + msgs_all.msg2);
                
            }
        }
        string msgC="";
        string msg3="";
        int b=0;
        int c=1;
        int aaa=0;
        public void sendMsgtoCustomer(){
            Console.WriteLine("type message for manager");
            msgC =Console.ReadLine();
            addMsgForCustomer( msgC,b,c);
        }
        public void addMsgForCustomer(string msgC,int b,int c)
        {
            start mFC = new start(msgC,b,c);
            List.allMsg.Add(mFC);
        }
        public start(string msgC,int b,int c)
        {
            this.msg3 = msgC;
            this.aaa=b;
            this.c=c;
        }

        
          public void showMsgOfManagerForCustomer()
        {
            for (int i = 0; i < List.allMsg.Count; i++)
            {
                start msgs3_all = (start)List.allMsg[i];
                Console.WriteLine("message of managr : " + msgs3_all.msg3);
                
            }
        }
        string msgD="";
        string msg4="";
        int L=0;
        int k=1;
        int ttt=0;
        int x=8;
        public void sendMsgManager(){
            Console.WriteLine("type message for manager");
            msgD =Console.ReadLine();
            addMsgManager( msgD,L,k,x);
        }
        public void addMsgManager(string msgD,int L,int k,int x)
        {
            start mFC = new start(msgD,L,k,x);
            List.allMsg.Add(mFC);
        }
        public start(string msgD,int L,int k,int x)
        {
            this.msg4 = msgD;
            this.ttt=L;
            this.k=k;
            this.x=x;
        }

        
          public void showMsgOfCustomerToManager()
        {
            for (int i = 0; i < List.allMsg.Count; i++)
            {
                start msgs4_all = (start)List.allMsg[i];
                Console.WriteLine("message of Customer : " + msgs4_all.msg4);
                
            }
        }
    }

    abstract class manue : start
    {
        public abstract string getName();
        public abstract void setName();
    }

    class workers : manue
    {
        string Admin = "hassan";
        int pin = 123;
        int Gage = 0;
        int Sage = 0;
        int Gexp = 0;
        int Sexp = 0;
        public string wName = "";
        public int wAge = 0;
        public int wExp = 0;
        string name = "";
        string adminN = "";
        int adminP = 0;
        int optionA = 0;
        public workers()
        {

        }
        public workers(string adminName, int adminPin)
        {
            this.adminN = adminName;
            this.adminP = adminPin;
            Console.Clear();
            if (adminN == Admin && adminP == pin)
            {
                Console.WriteLine("login sucessfully");
                Console.WriteLine("press any key to countinue");
                Console.ReadKey();
                while (optionA != 7)
                {
                    manue2();
                    getValueFunction();
                    optionA = setValueFunction();
                    Console.Clear();

                    if (optionA == 1)
                    {
                        string wName = "";
                        int wAge = 0;
                        int wExp = 0;

                        setName();
                        wName = getName();

                        getWage();
                        wAge = setWage();

                        getWexp();
                        wExp = setWexp();

                        if (wAge > 0 && wAge < 60 && wExp > 1)
                        {
                            addWorkers(wName, wAge, wExp);
                        }
                    }
                    if (optionA == 2)
                    {
                        showWorkersDetail();
                        Console.WriteLine("press any key to countinue");
                        Console.ReadKey();
                    }
                    if (optionA == 3)
                    {
                          changeWorker();
                        Console.WriteLine("press any key to countinue");
                        Console.ReadKey();
                       
                    }
                    if(optionA == 4){
                        showProductDetail();
                       Console.WriteLine("press any key to countinue");
                       Console.ReadKey();
                        
                    }
                    if(optionA == 5){
                       sendMsg();
                       Console.WriteLine("press any key to countinue");
                        Console.ReadKey();
                    }
                    if(optionA == 6){
                        showMsgOfManager();
                        Console.WriteLine("press any key to countinue");
                        Console.ReadKey();
                    }
                    

                }
            }
            else
            {
                Console.WriteLine("invalid name or password");
                Console.WriteLine("press any key to countinue");
                Console.ReadKey();
            }
        }

        public workers(string wName, int wAge, int wExp)
        {
            this.wName = wName;
            this.wAge = wAge;
            this.wExp = wExp;
        }
        public void addWorkers(string wName, int wAge, int wExp)
        {
            workers w1 = new workers(wName, wAge, wExp);
            List.allWorkers.Add(w1);
        }


        public void getWage()
        {
            Console.WriteLine("enter the age");
            Gage = Convert.ToInt32(Console.ReadLine());
            if (Gage > 0 && Gage <= 60)
            {
                Sage = Gage;
            }
        }
       
        public void getWexp()
        {

            Console.WriteLine("enter the experience");
            Gexp = Convert.ToInt32(Console.ReadLine());
            if (Gexp > 1 && Gexp <= 60)
            {
                Sexp = Gexp;

            }
        }
        public void changeWorker(){
            setName();
            name = getName();
            for (int i = 0; i < List.allWorkers.Count; i++)
            {
                
                workers worker_all = (workers)List.allWorkers[i];
                if(name == worker_all.wName){
                    Console.WriteLine("name which you want to change");
                    setName();
                    
                    name = getName();
                    worker_all.wName = name;
                    Console.WriteLine("sucessfully changed worker");
                }
            }
            
        }
        public int setWage()
        {
            return Sage;
        }
        public int setWexp()
        {
            return Sexp;
        }
        public override void setName()
        {
            Console.WriteLine("enter the name");
            name = Console.ReadLine();
        }
        public override string getName()
        {
            return name;
        }

    }

    class manager : workers
    {
        int Gage = 0;
        int Sage = 0;
        int Gexp = 0;
        int Sexp = 0;
        string name = "";
        string Mname = "ali";
        int Mpin = 111;
        int optionM = 0;
        public string pName = "";
        public int pQuantity = 0;
        public int pPrice = 0;
        public manager()
        {

        }
       
        
        public manager(string pName, int pQuantity, int pPrice)
        {
            this.pName = pName;
            this.pQuantity = pQuantity;
            this.pPrice = pPrice;
        }
        public manager(string managerName, int managerPin)
        {
            if (managerName == Mname && managerPin == Mpin)
            {
                Console.Clear();
                Console.WriteLine("login sucessfully");
                Console.WriteLine("press any key to countinue");
                Console.ReadKey();
                while (optionM != 6)
                {
                    manue3();
                    getValueFunction();
                    optionM = setValueFunction();
                    Console.Clear();
                    if (optionM == 1)
                    {
                        string pName = "";
                        int pQuantity = 0;
                        int pPrice = 0;
                        setName();
                        pName = getName();
                        getPquan();
                        pQuantity = setPquqn();
                        getPprice();
                        pPrice = setPprice();
                        if (pQuantity > 1 || pPrice > 0)
                        {
                            addProduct(pName, pQuantity, pPrice);
                        }
                    }
                    if (optionM == 2)
                    {

                        showProductDetail();
                        Console.WriteLine("count " + List.allProducts.Count);
                        Console.WriteLine("press any key to countinue");
                        Console.ReadKey();
                    }
                    if (optionM == 3)
                    {
                        changeProduct();
                        Console.WriteLine("press any key to countinue");
                        Console.ReadKey();
                        
                    }
                    if(optionM == 4){
                         sendMsgtoAdmin();
                        Console.WriteLine("press any key to countinue");
                        Console.ReadKey();
                    }
                    if(optionM == 5){
                        showMsgOfAdmin();
                        Console.WriteLine("press any key to countinue");
                        Console.ReadKey();
                    }if(optionM == 6){
                        sendMsgtoCustomer();
                        Console.WriteLine("press any key to countinue");
                        Console.ReadKey();
                    }
                    if(optionM == 7){
                        showMsgOfCustomerToManager();
                        Console.WriteLine("press any key to countinue");
                        Console.ReadKey();
                    }

                }
            }
            else
            {
                Console.WriteLine("invalid data");
                Console.WriteLine("press any key to countinue");
                Console.ReadKey();
            }
        }
        public void addProduct(string pName, int pQuantity, int pPrice)
        {
            manager p1 = new manager(pName, pQuantity, pPrice);
            List.allProducts.Add(p1);
        }
        public void getPquan()
        {

            Console.WriteLine("enter the quantity");
            Gage = Convert.ToInt32(Console.ReadLine());
            if (Gage > 0 && Gage <= 1000)
            {
                Sage = Gage;

            }

        }
        public void changeProduct(){
            setName();
            name = getName();
            for (int i = 0; i < List.allProducts.Count; i++)
            {
                
                manager product_all = (manager)List.allProducts[i];
                if(name == product_all.pName){
                    Console.WriteLine("product which you want to change");
                    setName();
                    name = getName();
                    product_all.pName = name;
                    Console.WriteLine("sucessfully changed product");
                }
            }
            
        }
        public void getPprice()
        {

            Console.WriteLine("enter the price");
            Gexp = Convert.ToInt32(Console.ReadLine());
            if (Gexp > 1)
            {
                Sexp = Gexp;

            }
        }
        public int setPquqn()
        {
            return Sage;
        }
        public int setPprice()
        {
            return Sexp;
        }
        public override void setName()
        {

            Console.WriteLine("enter the name");
            name = Console.ReadLine();
        }
        public override string getName()
        {
            return name;
        }

    }

    class shop : manager
    {
        int sale = 0;
        string paintName = "";
        int paintQuantity = 0;
        int optionC = 0;
        public shop()
        {

        }
        public shop(string customerName)
        {
            while (optionC != 6)
            {
                manue6();
                Console.WriteLine("enter your option");
                optionC = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                if (optionC == 1)
                {
                    showProductDetail();
                    Console.WriteLine("press any key to countinue");
                    Console.ReadKey();
                }
                if (optionC == 2)
                {
                    buyPaint();
                    Console.WriteLine("press any key to countinue");
                    Console.ReadKey();
                }
                if (optionC == 3)
                {
                    varity();
                    Console.WriteLine("press any key to countinue");
                    Console.ReadKey();
                }
                if(optionC == 4){
                    sendMsgManager();
                    Console.WriteLine("press any key to countinue");
                    Console.ReadKey();
                }
                if(optionC == 5){
                    showMsgOfManagerForCustomer();
                    Console.WriteLine("press any key to countinue");
                    Console.ReadKey();
                }

            }

        }
        public void varity()
        {
            Console.WriteLine(" blue spark");
            Console.WriteLine(" off white ");
            Console.WriteLine(" ros white ");
            Console.WriteLine(" apple green ");
            Console.WriteLine(" voiet shade");
            Console.WriteLine(" black maat");
        }
        public void buyPaint()
        {
            Console.WriteLine("enter the name of paint which you want to buy");
            paintName = Console.ReadLine();
            Console.WriteLine("enter the quantity of paint which you buy");
            paintQuantity = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < List.allProducts.Count; i++)
            {
                manager product_all = (manager)List.allProducts[i];

                if (product_all.pName == paintName)
                {
                    if (product_all.pQuantity > 0)
                    {
                        sale = product_all.pPrice * paintQuantity;
                        product_all.pQuantity = product_all.pQuantity - paintQuantity;
                        Console.WriteLine("sucessfully purchased");
                        Console.WriteLine("your current bil is...." + sale);

                    }

                }
            }
        }



    }

    class Program
    {
        static void Main(string[] args)
        {
            start s1 = new start();
            s1.manue1();
        }
    }
}

