using System;
using System.Collections.Generic;
using System.Text;

namespace BirdManagementSystem
{
    internal class BirdManager
    {
        HashSet<Bird> birdList = new HashSet<Bird>();

        public void AddBirds(Bird bird)
        {
            try
            {
                if (!birdList.Add(bird))    throw new Exception("Bird already exists");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void RemoveBirds(Bird bird) 
        {

            try
            {
                if (!birdList.Remove(bird)) throw new Exception("Bird does not exist");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int CountTotalBirds()
        {
            return birdList.Count();
        }


        public int CountBirdsEachType(Type birdType)
        {
            try
            {
                if (birdType == null)
                {
                    throw new ArgumentNullException(nameof(birdType));
                }

                int count = 0;

                foreach (Bird bird in birdList)
                {
                    if (bird.GetType() == birdType)
                    {
                        count++;
                    }
                }

                return count;
            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }

    }



