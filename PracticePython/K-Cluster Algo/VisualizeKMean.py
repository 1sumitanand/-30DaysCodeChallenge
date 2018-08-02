""" this demo shows how to read data.txt file given in the python demo """

import os
import numpy
import matplotlib.pyplot as plt
import scipy
import importlib
from kmeansdemo import KMeansComputation

import kmeansdemo
### Relaod every time even if I change kmeansdemo
importlib.reload(kmeansdemo)


class VisualizeKMean(KMeansComputation):
    
    """Global Variables"""
    url = r"C:\Users\INSANAnD\Desktop\ML\Assignments\Assignment-1\data_2D.txt"
    points = numpy.loadtxt(url, float, '#', ',')    
    X = points[:,0]
    Y = points[:,1]
    print("Printed Global Variables")

    def __init__(self):
     print("Called through Constructer ")
     self.ScatteringData()
     self.ScatteringCentroids()
     self.ScatteringComputedCentroids()
     self.MiscelleniousData()

    def ReadingAndPrinintgData(self):
        ## r--read mode, w -- write mode, rb -- read binary we need to convert,
        ## wb
        datafile = open(url, 'r') #
        #datafile.
        line = datafile.readline()       
        print(line)
        # Storing in Array sepertaed by comma
        numberStrList = line.split(',')
        #general expression for each iteration in list convert it to float
        numberList = [ float(x) for x in numberStrList ]    
        print(numberStrList,sep = "\n")
        print(numberList,sep = "\n")
    
    """Scattering data over plot"""
    def ScatteringData(self):
       plt.scatter(self.X,self.Y,s=20)
       plt.show()
    
    """Scattering Centroids over plot"""
    def ScatteringCentroids(self):
       #taking centroids as k=2
       centroids = self.init_centroids(self.points, 2)
       print("computed centroids : ",centroids,sep = "\n")
       color = numpy.arange(2)
       #s=area size, c=colors
       plt.scatter(centroids[:, 0], centroids[:, 1], c=color, s=25)
       plt.show()
       
    """Scattering Centroids over plot"""
    def ScatteringComputedCentroids(self):
      kmeansCentroids = self.computeKMeans(self.points , 5)   
      #Hardcoded Colors for dataset  
      group_colors = ['skyblue', 'coral', 'lightgreen', 'violet', 'darkred']
      #Assigning Colors for each closest centroids
      datasetcolors = [group_colors[j] for j in self.closestCentroids(self.points,kmeansCentroids)] 
      #Hardcoded Colors for Centriods
      color = numpy.arange(5)
      plt.scatter(self.X, self.Y,color=datasetcolors, s=10)
      plt.scatter(kmeansCentroids[:, 0], kmeansCentroids[:, 1], c=color, s=35)
      plt.show()
    
    def MiscelleniousData(self):
      # A = (points[0:3,:] - centroids[:,numpy.newaxis])**2
      # print("numpy expression 1 : ", points[0:3,:])
      # print("numpy expressions 2 : ", centroids)
      centroids = self.init_centroids(self.points, 4)
      C = self.points[0:3,:] - centroids[0:1,:]
      print("C : ",C ** 2,sep = "\n")    
      distRow = numpy.sqrt(numpy.sum(C ** 2,1))
      print("distance row : ", distRow,sep = "\n")
      
      # distances = numpy.sqrt(((points[0:3,:] -
      # centroids[0:1,:])**2).sum(1))#[:, numpy.newaxis]
      C1 = self.points[0:3,:] - centroids[:, numpy.newaxis]
      print("C1 shape : ", C1.shape,sep = "\n")
      C1Square = C1 ** 2
      print("C1 square : ", C1Square.shape,sep = "\n")
      distances = numpy.sqrt(((self.points[0:3,:] - centroids[:, numpy.newaxis]) ** 2).sum(2))
      m1 = (self.points[0:3,:] - centroids[:, numpy.newaxis])
      print(" m1 : ", centroids[numpy.newaxis].shape,sep = "\n")
      print("distances : ", distances,sep = "\n")
      dists = scipy.spatial.distance.cdist(self.points[0:3],centroids)
      print(" scipy distances : ",dists,sep = "\n")
      minIds = numpy.argmin(dists, 1)
      print("Miminum Indices : ",minIds)

# Creating instance and calling constructer
if __name__ == "__main__":
    visualizeKMean = VisualizeKMean()



