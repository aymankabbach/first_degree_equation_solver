#include <iostream>
#include <cmath>
using namespace std;
float read_user_input_value(string variable)
{
    float float_number;
    cout << "enter the value of "<<variable<<endl;
    cin>>float_number;
    return float_number;
}
bool check_speciale_case(float variable_a,float variable_b)
{
    return (variable_a==0 && variable_b==0 || variable_a==0);
}
float solve_equation(float variable_a,float variable_b)
{
    float result=-variable_b/variable_a;
    return result;
}
void print_special_case_result(float variable_a,float variable_b)
{
    if (variable_a==0)
    {
        if (variable_b==0)
        {
            cout<< "all numbers are solutions to this equation"<<endl;
        }
        else
        {
            cout<<"this equation has no solution"<<endl;
        }
    }
}
void print_result(float variable_a,float variable_b)
{
    float result=solve_equation(variable_a,variable_b);
    cout<<"result = "<<result<<endl;
}
int main()
{
    float variable_a=read_user_input_value("a");
    float variable_b=read_user_input_value("b");
    bool special_case=check_speciale_case(variable_a,variable_b);
    if (special_case)
    {
        print_special_case_result(variable_a,variable_b);
    }
    else
    {
        print_result(variable_a,variable_b);
    }
}