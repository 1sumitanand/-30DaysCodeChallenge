     
class IShape(object):
  def __init__(self):
      pass
  GeometryName = ""
  def show(self):
        raise Exception("NotImplementedException")

class Circle(IShape):
      
   GeometryName = "Circle Class"
   
   def show(self):
       print("I am Circle !")
      
class Rectangle(IShape):
  
   GeometryName = "Rectangle Class"
      
   def show(self):
       print("I am Rectangle !")

class A():
  
 _Shapes = [Circle(),Rectangle()]
 
 def __init__(self):
   print("A Class Constructer ")
   self.CheckConditionAndPassMethod()

 def CheckConditionAndPassMethod(self): 
   for a in self._Shapes:
    if(a.GeometryName == "Circle Class"): 
      a.show()

if __name__ == "__main__":
    obj = A()