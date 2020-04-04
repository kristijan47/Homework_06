using System;

namespace Homework_06
{

    //        Task 1

    //Task 1 Create a class "PhotoAlbum" with a private attribute "numberOfPages".

    //It should also have a public method "GetNumberOfPages", which will return the number of pages.

    //The default constructor will create an album with 16 pages.There will be an additional constructor,
    // with which we can specify the number of pages we want in the album.

    //Create a class "BigPhotoAlbum" whose constructor will create an album with 64 pages.

    //In main method create a "PhotoAlbum" instance with its default constructor and one with 24 pages.Also create "BigPhotoAlbum"
    // and show the number of pages that the three albums have.

    public class PhotoAlbum

    {
        private int NumberOfPages;

        public PhotoAlbum()
        {
            NumberOfPages = 16;

            
        }
       

       public PhotoAlbum(int numberOfPages)
        {
            NumberOfPages = numberOfPages;
        }

        

        public int GetNumberOfPages()
        {
            return NumberOfPages;
        }

        
    }

    public class BigPhotoAlbum
    {
        private int NumberOfPages;

        public BigPhotoAlbum()
        {
            NumberOfPages = 64;
        }

        public int GetNumberOfPages()
        {
            return NumberOfPages;
        }

        public BigPhotoAlbum(int numberOfPages)
        {
            NumberOfPages = numberOfPages;
        }
    }
  
    class Program
    {

        static void Main(string[] args)
        {
            PhotoAlbum firstAlbum = new PhotoAlbum();
            Console.WriteLine(firstAlbum.GetNumberOfPages());

          

            PhotoAlbum newAlbum = new PhotoAlbum(24);
            Console.WriteLine(newAlbum.GetNumberOfPages());

            BigPhotoAlbum thirdAlbum = new BigPhotoAlbum();
            Console.WriteLine(thirdAlbum.GetNumberOfPages());
            
        }
    }
}
