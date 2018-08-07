""" This Example will use Classes with List , Dictionary and Linq expression
    1. Empty Check for List or Dictionary
    2. Checking Key in Dictionary
    3. Dictionary Initialization
    4. pass keyword
"""

""" "pass" keyword (a statement) to indicate that nothing happens—the function, class or loop is empty. 
     With pass, we indicate a "null" block. Pass can be placed on the same line, or on a separate line. 
     Pass can be used to quickly add things that are unimplemented."""

class Shape(object):
     
    def __init__(self):
      pass
 
    def show(self):
        raise Exception("Not Implemented Exception")

class A(Shape):
         
   def show(self):
       print("I am A !!")
      
class B(Shape):
    
   def show(self):
       print("I am B !!")

class IfCaseScenario(object):
    List_Class_Instances = []  
   
    def __init__(self):
      self.ListInitialization1("A Class")		
            
    def ListInitialization1(self, ShObj):
     if ShObj == 'A Class':
        self.List_Class_Instances.append(A())
        self.List_Class_Instances.append(B())  
     elif type(ShObj) is B:
        self.List_Class_Instances.append(B())   

    def PrintList(self):
        print("Number of Class Instances are : " , len(self.List_Class_Instances)) 
        print("List Instances are : " , self.List_Class_Instances) 

class RefactoredIfCaseScenario(object):
    List_Class_Instances = []  
    Dictionary_Class_Instances = { 'A Class':'A()' , 'B Class':'B()' , 'C Class':'C()', 'D Class':'D()'}
   
    """ In this constructer we are just passing AObj """    
    def __init__(self):
      self.ListInitialization1("A Class")
            
    """ In this method we are just passing AObj from above and checking in for loop against dictionary to load the conditions """
    def ListInitialization1(self, ShObj):
        if ShObj in self.Dictionary_Class_Instances.keys():
          self.List_Class_Instances.append(A())
          self.List_Class_Instances.append(B())
          self.List_Class_Instances.append("C String Value")
          self.List_Class_Instances.append(4)
         
    """ Prints the initialized data in a list"""    
    def PrintList(self):
       print("Number of List Instances are : " , len(self.List_Class_Instances)) 
       if not self.List_Class_Instances:
        print("Nothing here Empty List")
       else:      
        print("List Instances are : " , self.List_Class_Instances) 

if __name__ == "__main__": 
    Aobj = A()
    Bobj = B() 
    """ Print the List """   
    IfCaseobj = IfCaseScenario()   
    IfCaseobj.PrintList()
    """ Refactored Class Sceanrio """
    RObj = RefactoredIfCaseScenario()
    RObj.PrintList()