"""This includes simple implementation of kmeans using python"""

import matplotlib.pyplot as pyplot
import numpy
import seaborn as sns; sns.set()
import scipy

class KMeansComputation:
       
    def init_centroids(self, points , k):
        """returns k centroids from initial points"""
        centroids = points.copy()
        numpy.random.shuffle(centroids)
        return centroids[0:k,:]
      
    def closestCentroids(self, points , centroids ):
        """ for each point in points numpy array , the function computes index for closest 
        centroid and returns the array of indices """
        dists = scipy.spatial.distance.cdist(points,centroids)
        # 1 is dimension
        minIds = numpy.argmin(dists, 1)
        return minIds
    
    def updateCentroids(self, points, closest, centroids):
        """returns the new centroids assigned from the points closest to them"""
        return numpy.array([points[closest==k].mean(axis=0) for k in range(centroids.shape[0])])    
     
    def computeKMeans(self, points,  k):
        """ computes kmeans on the given data , given the cluster size and initial centroids """
        centroids = self.init_centroids(points,k)
        
        for i in range(5):
         closest =  self.closestCentroids(points,centroids)
         centroids =  self.updateCentroids(points, closest ,centroids)

        return centroids



       


