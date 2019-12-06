using System.Runtime.CompilerServices;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Collections;
using System;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace c_{
    public class employee
    {

        public int EmployeeID{get; set;}
        public string FirstName{get; set;}
        private List<String> Roles;
        private double Salary{get; set;}
        public double Bouns{get;set;}
        public int shiftHours{get;set;}
        private string ShiftStart{get; set;}
        private string ShiftEnds{get; set;}
        public DateTime workingDaysInWeek {get; set;}
        public DateTime HolidayStartsIn;
        public DateTime HolidayEndsIn;
        public int daysAbsentinThisMounth{get; set;}
        public DateTime DateOfBirth{get;set;}
        public string placeOfBirth{get;set;}
        public string Gender{get;set;}
        public string Qualfication{get;set;}
        public bool isOnHoliday;
        public string empState;
        private string authority;
        public string profile;
        public int OverTime{get; set;}
        public string execused{get;set;}
        Departments dep = new Departments();

                public void setHoliday(DateTime Hin ,DateTime Hend){
                this.HolidayEndsIn = Hend;
                this.HolidayStartsIn = Hin;

        }

        /*
        *
         * *  this function check if employee is on a vacation or not
           * *
               */
        public string CheckHoliday(){
          TimeSpan untilEnd = HolidayEndsIn.Subtract(DateTime.Now);
          Console.WriteLine(untilEnd.TotalDays + " remaining days from today to end of holiday\n ");

          TimeSpan ts = HolidayEndsIn.Subtract(HolidayStartsIn);
          Console.WriteLine(ts.TotalDays + " end - start \n ");

        if(untilEnd.TotalDays > 0){

          if(untilEnd.TotalDays < ts.TotalDays)
          {
              return "it's holiday";
          } 
          else
          {
            return "Holiday has finished";
          }
            
            }
            else
            {
                return "holiday has finished";
            }
        } 

        public double deductSalaryByRatio(double ratio)
        {
            double temp = 0;
            if ( ratio > 0 ){
            temp = ratio * Salary;
            }
            else 
            {
                return 0;
            }
            return Salary - temp;
        }
        public void addBouns(double amount)
        {
            Salary += Bouns;
        }


         public void addEmployee(){
             if(authority.Equals("Admin")){
                 //can add employees
             }
             else{
                 //cant add employees
             }
         }
         public void setID(int id){
             this.EmployeeID = id;
         }
       
        public void addToSalary(double amount){
            this.Salary += amount;
        }

        public void addRolesToEmployee(string role){
            this.Roles.Add(role);
        }
        public void requestHoliday (employee emp){
            
        }
        public void writeOverTime(){
           var db = DBconnection.Instance();
            string query = "UPDATE Inventory SET OverTime = @OverTime  WHERE empID = @empID";
            if (db.IsConnect())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@OverTime", OverTime);
                cmd.Parameters.AddWithValue("@empID", EmployeeID);
                cmd.Connection = db.Connection;
                cmd.ExecuteNonQuery();
                db.Close();
            }
        }
       

    }
}