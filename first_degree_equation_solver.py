def read_the_value_from_the_user(variable):
    wrong_input=True
    while wrong_input==True:
        try:
            user_input=float(input(f"insert the value of {variable}"))
        except ValueError:
            pass
        else:
            wrong_input=False
    return user_input
def solve_the_equation():
    variable_a=read_the_value_from_the_user("a")
    variable_b=read_the_value_from_the_user("b")
    if (variable_a == 0):
        if (variable_b == 0):
            return "all numbers are solutions to this equation"
        else:
            return "this equation has no solution"
    else :
        return f"x= {-variable_b/variable_a}"
def print_result():
    result=solve_the_equation()
    print(result)
print_result()