using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStore.Models;
using BookStore.Models.Store;
using System.Data.Entity;

namespace BookStore.DAL
{
    public class BookStoreInitializer : DropCreateDatabaseIfModelChanges<BookStoreContext>
    {
        protected override void Seed(BookStoreContext context)
        {
            // base.Seed(context);
            var admins = new List<Admin>
            {
                new Admin
                {
                    Department = "Admin",
                    Email = "admin@admin.com",
                    Account = new Account
                    {
                        Username="admin", PasswordHash="admin", Role = "Admin"
                    },
                    FirstName = "Admin",
                    LastName = "Admin",
                    Position = "Admin",
                    JoinDate = "2/2/2025"
                }
            };

            var users = new List<User>
            {
                new User
                {
                    Account = new Account { Username = "john", PasswordHash = "john", Role = "User" },
                    Books = null,
                    Email = "john@john.john",
                    FullName = "John",
                },
                new User
                {
                    Account = new Account { Username = "user", PasswordHash = "user", Role = "User" },
                    Books = null,
                    Email = "user@user.user",
                    FullName = "User",
                }
            };
            
            var books = new List<Book>
            {
    new Book
            {
                Title = "Captains Courageous",
                Author = "Rudyard Kipling",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1897, 1, 1),
                    Pages = 218,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Castrovilli Giuseppe",
                    Description = @"Portugese fisherman teaches human values to a spoiled young millionaire&#x27;s son who was saved from drowning."
                },
                Price = 23.46,
                Category = Category.Classic,
                RatingCount = 593,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/5017156ac3cdb363e9cb07b68754ec8c.jpg" }
                }
            },
    new Book
            {
                Title = "Captains Courageous",
                Author = "Rudyard Kipling",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1897, 1, 1),
                    Pages = 350,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Castrovilli Giuseppe",
                    Description = @"Portugese fisherman teaches human values to a spoiled young millionaire&#x27;s son who was saved from drowning."
                },
                Price = 17.96,
                Category = Category.Classic,
                RatingCount = 1,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/5017156ac3cdb363e9cb07b68754ec8c.jpg" }
                }
            },
    new Book
            {
                Title = "Tom Sawyer",
                Author = "Mark Twain, Barbara Cottingham",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1995, 1, 1),
                    Pages = 256,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Landoll",
                    Description = @"The classic boy-hero of American literature. Impish, daring young Tom Sawyer is the bane of the old, the hero of the young. There were some in his dusty old Mississippi town who believed he would be President, if he escaped a hanging. For wherever there is mischief or adventure, Tom is at the heart ..."
                },
                Price = 19.68,
                Category = Category.Classic,
                RatingCount = 942,
                Rating = 3.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/fe36f4602ffb832359cd6463674b99a4.jpg" }
                }
            },
    new Book
            {
                Title = "The House of the Seven Gables",
                Author = "Nathaniel Hawthorne, Philip Young",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1970, 1, 1),
                    Pages = 280,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Holt McDougal",
                    Description = @"No description available."
                },
                Price = 24.02,
                Category = Category.Classic,
                RatingCount = 345,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/placeholder.jpg" }
                }
            },
    new Book
            {
                Title = "A Translation of the First Book of Ovid&#x27;s Tristia",
                Author = "Ovid",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1821, 1, 1),
                    Pages = 156,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 6.17,
                Category = Category.Classic,
                RatingCount = 634,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/ff8d8b3d15fc5b2df6b582921632724f.jpg" }
                }
            },
    new Book
            {
                Title = "Robinson Crusoe",
                Author = "Daniel Defoe",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2001, 1, 1),
                    Pages = 52,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Evans Brothers",
                    Description = @"Storm, shipwreck, pirates, and mutiny are the timeless themes of this recreated classic. The action-packed story lines retain all the impact of the author&#x27;s own words, while photos and narrative illustrations help readers to absorb the full flavor of the original novel. Full color. Copyright © ..."
                },
                Price = 11.01,
                Category = Category.Classic,
                RatingCount = 7,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/3da3ce694e95fc157eec5d9ec2078260.jpg" }
                }
            },
    new Book
            {
                Title = "Sanctuary",
                Author = "William Faulkner",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1981, 1, 1),
                    Pages = 328,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "New York : Random House",
                    Description = @"Brutal novel of the Deep South by the Nobel prize winner."
                },
                Price = 24.43,
                Category = Category.Classic,
                RatingCount = 1,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/4ce63397e604a28981bc57783bfdddd9.jpg" }
                }
            },
    new Book
            {
                Title = "The Mystery of the Blue Train",
                Author = "Agatha Christie",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1985, 1, 1),
                    Pages = 248,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"A BBC full-cast radio drama starring Maurice Denham as the great Belgian detective. A millionaire strikes a deal on the seedier side of Paris and gives to his heartsick daughter, Ruth Kettering, the &quot;Heart of Fire,&quot; one of the world&#x27;s legendary jewels. Legend has it that the possessio..."
                },
                Price = 29.99,
                Category = Category.Classic,
                RatingCount = 453,
                Rating = 3.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/76e3acf07139095e92fc7601d9c0549a.jpg" }
                }
            },
    new Book
            {
                Title = "A Connecticut Yankee in King Arthur&#x27;s Court",
                Author = "Mark Twain",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1890, 1, 1),
                    Pages = 575,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 10.22,
                Category = Category.Classic,
                RatingCount = 975,
                Rating = 3.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/placeholder.jpg" }
                }
            },
    new Book
            {
                Title = "Little Lord Fauntleroy",
                Author = "Frances Hodgson Burnett",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1994, 1, 1),
                    Pages = 290,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "NTC/Contemporary Publishing Company",
                    Description = @"Burnett&#x27;s conviction that love conquers all is memorably embodied in this tale of an American boy who is transported from the mean streets of 19th-century New York to the splendor of his titled grandfather&#x27;s English manor. &quot;Compellingly readable.&quot; - Horn Book."
                },
                Price = 18.3,
                Category = Category.Classic,
                RatingCount = 201,
                Rating = 3.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/69af02f9c0586b3f7fe4a65d7667a754.jpg" }
                }
            },
    new Book
            {
                Title = "Moby-Dick",
                Author = "Herman Melville",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1981, 1, 1),
                    Pages = 610,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Bantam Classics",
                    Description = @"For this Sesquicentennial Norton Critical Edition, the Northwestern-Newberry text of Moby-Dick has been generously footnoted to include dozens of biographical discoveries, mainly from Hershel Parker&#x27;s work on his two-volume biography of Melville."
                },
                Price = 20.58,
                Category = Category.Classic,
                RatingCount = 678,
                Rating = 4.1f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/99756b6ad008dc652a08cee559e4775a.jpg" }
                }
            },
    new Book
            {
                Title = "Lord Edgware Dies",
                Author = "Agatha Christie",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1984, 1, 1),
                    Pages = 260,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Berkley",
                    Description = @"John Moffatt stars as the great Belgian detective in this BBC Radio full-cast dramatization. &quot;Monsieur Poirot, somehow or other I&#x27;ve just got to get rid of my husband!&quot; No sooner had she uttered the words than Lady Edgware&#x27;s husband was dead, brutally stabbed in the neck. The evi..."
                },
                Price = 18.3,
                Category = Category.Classic,
                RatingCount = 198,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/8152bcd9d304fa5a302a5be0de919885.jpg" }
                }
            },
    new Book
            {
                Title = "The Fortunes and Misfortunes of the Famous Moll Flanders",
                Author = "Daniel Defoe",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1989, 1, 1),
                    Pages = 496,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Penguin UK",
                    Description = @"Born in Newgate prison and abandoned six months later, Moll&#x27;s drive to find and hold on to a secure place in society propels her through incest, adultery, bigamy, prostitution and a resourceful career as a thief (&#x27;the greatest Artist of my time&#x27;) before she is apprehended and returned..."
                },
                Price = 21.7,
                Category = Category.Classic,
                RatingCount = 903,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/3577a33a9e7fa5ccdfa6179def746c6e.jpg" }
                }
            },
    new Book
            {
                Title = "David Balfour",
                Author = "Robert Louis Stevenson",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1994, 1, 1),
                    Pages = 840,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"The further adventures of David Balfour in which he continues his friendship with Alan Breck Stewart and support of the Scottish highlanders&#x27; cause, travels abroad to complete his education, and finds romance."
                },
                Price = 7.46,
                Category = Category.Classic,
                RatingCount = 776,
                Rating = 4.2f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/4e24428544c32cd2c6bd66e4babeb243.jpg" }
                }
            },
    new Book
            {
                Title = "Prairie",
                Author = "James Fenimore Cooper",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1964, 1, 1),
                    Pages = 420,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Signet Classics",
                    Description = @"The last volume in the magnificent saga of Natty Bumppo, in which he is drawn into an involvement with society in the form of an emigrant party led by the outcast Ishmael Bush."
                },
                Price = 12.43,
                Category = Category.Classic,
                RatingCount = 949,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/4cbfbfb95ce0f7f7f6d3dbe6420e1a53.jpg" }
                }
            },
    new Book
            {
                Title = "The Talisman",
                Author = "Walter Scott",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1929, 1, 1),
                    Pages = 364,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"Through a series of adventures, a poor but doughty Scottish crusader known as Sir Kenneth proves his honor and discovers his destiny in Sir Walter Scott&#x27;s tale of chivalry, violence, virtue, romance, and deceit."
                },
                Price = 11.68,
                Category = Category.Classic,
                RatingCount = 993,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/8272250d7c098001c6c7dd398653a3a8.jpg" }
                }
            },
    new Book
            {
                Title = "Nineteen Eighty-four",
                Author = "George Orwell",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2000, 1, 1),
                    Pages = 325,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"George Orwell&#x27;s dystopian masterpiece, Nineteen Eighty-Four is perhaps the most pervasively influential book of the twentieth century, published with an introduction by Ben Pimlott in Penguin Modern Classics. &#x27;Who controls the past controls the future: who controls the present controls the..."
                },
                Price = 25.11,
                Category = Category.Classic,
                RatingCount = 141,
                Rating = 4.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/2c47a8cc4bedda30a44bc7fb4722a4a9.jpg" }
                }
            },
    new Book
            {
                Title = "The Castle",
                Author = "Franz Kafka",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1954, 1, 1),
                    Pages = 524,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "London : Secker &amp; Warburg",
                    Description = @"Surrealistic novel whose shadowy characters and obscure events are said to reflect the condition of man in modern society."
                },
                Price = 24.2,
                Category = Category.Classic,
                RatingCount = 425,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/87c6ae0c1d8b6b9ba211a0cd10249a89.jpg" }
                }
            },
    new Book
            {
                Title = "The Story of King Arthur and His Knights",
                Author = "Unknown",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1965, 1, 1),
                    Pages = 344,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Courier Dover Publications",
                    Description = @"The King&#x27;s battle with the Sable Knight, his courtship of Lady Guinevere, and his establishment of the Round Table are included in this adaptation of Arthurian legend"
                },
                Price = 15.12,
                Category = Category.Classic,
                RatingCount = 384,
                Rating = 4.3f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/4a4cdfee8a3d3512ccafb4e25c6eeb1c.jpg" }
                }
            },
    new Book
            {
                Title = "Bridge to Terabithia",
                Author = "Katherine Paterson",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2007, 1, 1),
                    Pages = 163,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"It was Leslie who invented Terabithia - the secret country on an island in the dry creek. Here Jess could be strong, unafraid and unbeatable. So when something terrible happens, Jess finds he can face grief and disaster better than he could ever have imagined. Now a major motion picture."
                },
                Price = 23.77,
                Category = Category.Classic,
                RatingCount = 577,
                Rating = 4.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/82db804f409dda5ca043e239ea2ee8f8.jpg" }
                }
            },
    new Book
            {
                Title = "Rebecca",
                Author = "Daphne Du Maurier",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1975, 1, 1),
                    Pages = 404,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"An innocent young woman marries an older widower and tries to carve a place for herself at his family estate, dominated by the bitter memories of his first wife, Rebecca."
                },
                Price = 14.17,
                Category = Category.Classic,
                RatingCount = 3,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/65ed72f435ddd53cb3efb0b018ce2af4.jpg" }
                }
            },
    new Book
            {
                Title = "The Deerslayer",
                Author = "James Fenimore Cooper",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1963, 1, 1),
                    Pages = 544,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Signet Classics",
                    Description = @"The deadly crack of a long rifle and the piercing cries of Indians on the warpath shatter the serenity of beautiful lake Glimmerglass. Danger has invaded the vast forests of upper New York State as Deerslayer and his loyal Mohican friend Chingachgook attempt the daring rescue of an Indian maiden imp..."
                },
                Price = 5.99,
                Category = Category.Classic,
                RatingCount = 823,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/3649b27bac7a265f8d5e5a7d0feb12b9.jpg" }
                }
            },
    new Book
            {
                Title = "Sons and Lovers",
                Author = "David Herbert Lawrence",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1977, 1, 1),
                    Pages = 650,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Penguin Group",
                    Description = @"A provocative portrait of an artist torn between love for his possessive mother and desire for two young beautiful women. It is also the story of Paul Morel&#x27;s growing into manhood torn by both inner and outer conflict."
                },
                Price = 20.41,
                Category = Category.Classic,
                RatingCount = 317,
                Rating = 3.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/39d2f832be2027356c8aeb62f760924f.jpg" }
                }
            },
    new Book
            {
                Title = "The Plague",
                Author = "Albert Camus",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1958, 1, 1),
                    Pages = 294,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Penguin Classics",
                    Description = @"The townspeople of Oran are in the grip of a deadly plague, which condemns its victims to a swift and horrifying death. Fear, isolation and claustrophobia follow as they are forced into quarantine. Each person responds in their own way to the lethal disease: some resign themselves to fate, some seek..."
                },
                Price = 26.78,
                Category = Category.Classic,
                RatingCount = 802,
                Rating = 4.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/6e8b432d8fc548122b13058e381c47c8.jpg" }
                }
            },
    new Book
            {
                Title = "Dandelion Wine",
                Author = "Ray Bradbury",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2008, 1, 1),
                    Pages = 241,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "HarperCollins UK",
                    Description = @"An endearing classic of childhood fancies and memories of an idyllic mid-western summer from the author of Fahrenheit 451."
                },
                Price = 10.39,
                Category = Category.Classic,
                RatingCount = 310,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/77948e0910ae6cbf9f80a3dc46fd257a.jpg" }
                }
            },
    new Book
            {
                Title = "The Mayor of Casterbridge",
                Author = "Thomas Hardy",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1978, 1, 1),
                    Pages = 456,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Penguin Classics",
                    Description = @"From the stunning opening wife-selling scene (at one time a not uncommon phenomenon in England) to the final playing out his tragedy, Michael Henchard proves to be violent, selfish, greedy and crude. At the same time he possesses magnanimity, humility and a comparison that always pleased Hardy."
                },
                Price = 28.44,
                Category = Category.Classic,
                RatingCount = 695,
                Rating = 4.2f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/4fb9f1ba0ace5ffdfae01926507b1303.jpg" }
                }
            },
    new Book
            {
                Title = "The Time Machine",
                Author = "H. G. Wells",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2005, 1, 1),
                    Pages = 141,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Penguin UK",
                    Description = @"A time traveling scientist sees the future of man (802,701 A.D.) and then the inevitable future of the world."
                },
                Price = 24.79,
                Category = Category.Classic,
                RatingCount = 376,
                Rating = 3.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/c9a52f5499c2d5b7bd1f61da14ebe68d.jpg" }
                }
            },
    new Book
            {
                Title = "The Red Badge of Courage",
                Author = "Stephen. Crane",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1990, 1, 1),
                    Pages = 228,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"The finest literature in the world is now accessible to new readers!"
                },
                Price = 21.85,
                Category = Category.Classic,
                RatingCount = 362,
                Rating = 4.2f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/65af46ae6ba7190f3ad38c401be94169.jpg" }
                }
            },
    new Book
            {
                Title = "The Halloween Tree",
                Author = "Ray Bradbury",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1972, 1, 1),
                    Pages = 166,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Knopf Books for Young Readers",
                    Description = @"ON HALLOWEEN NIGHT, eight trick-or-treaters gather at the haunted house by the edge of town, ready for adventure. But when Something whisks their friend Pip away, only one man, the sinister Carapace Clavicle Moundshroud, can help the boys find him. &quot;If you want to know what Halloween is, or if ..."
                },
                Price = 25.99,
                Category = Category.Classic,
                RatingCount = 3,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/e2c3f5222b81126c2a072aae1adf5b2c.jpg" }
                }
            },
    new Book
            {
                Title = "Thirteen at Dinner",
                Author = "Agatha Christie",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1984, 1, 1),
                    Pages = 242,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Berkley",
                    Description = @"Beautiful actress Jane Wilkinson wants to exchange her husband for a wealthier one, when he is found murdered, all eyes turn to her."
                },
                Price = 21.7,
                Category = Category.Classic,
                RatingCount = 743,
                Rating = 3.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/465618d2144aa8db56caea27c4a543a0.jpg" }
                }
            },
    new Book
            {
                Title = "The Murder at the Vicarage",
                Author = "Agatha Christie",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1984, 1, 1),
                    Pages = 244,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Berkley Books",
                    Description = @"Colonel Protheroe, St. Mary Mead&#x27;s most loathed magistrate, has been found shot through the head. It isn&#x27;t his murder that raises eyebrows, but rather the scandalous secrets it exposes which send Miss Marple on the trail of a killer with something to hide. Reissue."
                },
                Price = 17.04,
                Category = Category.Classic,
                RatingCount = 4,
                Rating = 3.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/50a0db6303071418f335768d325aff13.jpg" }
                }
            },
    new Book
            {
                Title = "The Count of Monte Cristo",
                Author = "Alexandre Dumas",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2003, 1, 1),
                    Pages = 1610,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Penguin UK",
                    Description = @"Translated with an Introduction by Robin Buss"
                },
                Price = 25.98,
                Category = Category.Classic,
                RatingCount = 177,
                Rating = 4.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/9773cc66e2b62c2ee12799062e5aa20b.jpg" }
                }
            },
    new Book
            {
                Title = "The Metamorphosis",
                Author = "Franz Kafka",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1981, 1, 1),
                    Pages = 201,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 18.54,
                Category = Category.Classic,
                RatingCount = 806,
                Rating = 4.1f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/placeholder.jpg" }
                }
            },
    new Book
            {
                Title = "White Fang",
                Author = "Jack London",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1994, 1, 1),
                    Pages = 260,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 20.23,
                Category = Category.Classic,
                RatingCount = 142,
                Rating = 4.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/93be596e258dbaa1088952b84b84fda4.jpg" }
                }
            },
    new Book
            {
                Title = "Selected Short Stories",
                Author = "David Herbert Lawrence",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1982, 1, 1),
                    Pages = 550,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Penguin UK",
                    Description = @"Seven of the best Lawrence stories, each turning on some facet of sexual feeling, attitude, or convention: &quot;The Prussian Officer,&quot; &quot;The Shadow in the Rose Garden,&quot; &quot;The White Stocking,&quot; &quot;Daughters of the Vicar,&quot; &quot;The Christening,&quot; more."
                },
                Price = 23.21,
                Category = Category.Classic,
                RatingCount = 848,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/ef1fc153722574bf2351ff0a3f024ecf.jpg" }
                }
            },
    new Book
            {
                Title = "The Power and the Glory",
                Author = "Graham Greene",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1982, 1, 1),
                    Pages = 322,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Viking Adult",
                    Description = @"In a poor, remote section of southern Mexico, the Red Shirts have taken control, God has been outlawed, and the priests have been systematically hunted down and killed. Now, the last priest strives to overcome physical and moral cowardice in order to find redemption. 240 pp."
                },
                Price = 22.84,
                Category = Category.Classic,
                RatingCount = 733,
                Rating = 4.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/a2607535ccdcf06dde5903466979468f.jpg" }
                }
            },
    new Book
            {
                Title = "Hans Brinker",
                Author = "Unknown",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1988, 1, 1),
                    Pages = 52,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"A Dutch boy and girl work toward two goals, finding the doctor who can restore their father&#x27;s memory and winning the competition for the silver skates."
                },
                Price = 19.85,
                Category = Category.Classic,
                RatingCount = 853,
                Rating = 3.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/c37177d93803a8f6ee3b95c10e24ff65.jpg" }
                }
            },
    new Book
            {
                Title = "The Canterbury Tales",
                Author = "Geoffrey Chaucer, David Wright",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2008, 1, 1),
                    Pages = 482,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Oxford University Press, USA",
                    Description = @"A group of pilgrims entertain each other with stories on the road to Canterbury."
                },
                Price = 24.21,
                Category = Category.Classic,
                RatingCount = 246,
                Rating = 3.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/2b5b04bbd02a9b3b7e562b6f6ffb68f4.jpg" }
                }
            },
    new Book
            {
                Title = "The Hobbit, Or, There and Back Again",
                Author = "John Ronald Reuel Tolkien",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2003, 1, 1),
                    Pages = 0,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"Bilbo Baggins, the hobbit, is a peaceful sort who lives in a cozy hole in the Shire, a place where adventures are uncommon - and rather unwanted. So when the wizard Gandalf whisks him away on a treasure-hunting expedition with a troop of rowdy dwarves, he&#x27;s not entirely thrilled. Encountering r..."
                },
                Price = 22.68,
                Category = Category.Classic,
                RatingCount = 1,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/67836d5d16fbc8bddca15b84409e6888.jpg" }
                }
            },
    new Book
            {
                Title = "The Adventures of Sherlock Holmes",
                Author = "Sir Arthur Conan Doyle",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2012, 1, 1),
                    Pages = 0,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Atlantic Publishing, Croxley Green",
                    Description = @"Classics with legible texts you can actually read at a fantastic price."
                },
                Price = 25.98,
                Category = Category.Classic,
                RatingCount = 856,
                Rating = 4.2f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/215e9234d1ab8e3ff0e70e2d0d91bf9e.jpg" }
                }
            },
    new Book
            {
                Title = "The Silver Chair",
                Author = "Clive Staples Lewis",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1998, 1, 1),
                    Pages = 260,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "HarperCollins UK",
                    Description = @"Two English children undergo hair-raising adventures as they go on a search and rescue mission for the missing Prince Rilian, who is held captive in the underground kingdom of the Emerald Witch."
                },
                Price = 6.85,
                Category = Category.Fantasy,
                RatingCount = 74,
                Rating = 5.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/85dd252ea0787b367c029e9597efae2f.jpg" }
                }
            },
    new Book
            {
                Title = "Fablehaven",
                Author = "Brandon Mull",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2007, 1, 1),
                    Pages = 384,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"When Kendra and Seth go to stay at their grandparents&#x27; estate, they discover that it is a sanctuary for magical creatures and that a battle between good and evil is looming."
                },
                Price = 26.87,
                Category = Category.Fantasy,
                RatingCount = 65,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/ac72d0af0beb5d4dbcab1a9c7a286b3e.jpg" }
                }
            },
    new Book
            {
                Title = "A Wizard of Earthsea",
                Author = "Ursula K. Le Guin",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2012, 1, 1),
                    Pages = 267,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Houghton Mifflin Harcourt",
                    Description = @"Originally published in 1968, Ursula K. Le Guin&#x27;s A Wizard of Earthsea marks the first of the six now beloved Earthsea titles. Ged was the greatest sorcerer in Earthsea, but in his youth he was the reckless Sparrowhawk. In his hunger for power and knowledge, he tampered with long-held secrets a..."
                },
                Price = 25.13,
                Category = Category.Fantasy,
                RatingCount = 834,
                Rating = 4.2f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/8c74f7158471ba8580df88b9c3f1f80d.jpg" }
                }
            },
    new Book
            {
                Title = "Keeper of the Lost Cities",
                Author = "Shannon Messenger",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2012, 1, 1),
                    Pages = 496,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"At age 12, Sophie learns that the remarkable abilities that have always caused her to stand out identify her as an elf. After being brought to Eternalia to hone her skills, she discovers that she has secrets buried in her memory for which some would kill."
                },
                Price = 26.77,
                Category = Category.Fantasy,
                RatingCount = 11,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/22af39e452ddccedf205ee3e81ab92c3.jpg" }
                }
            },
    new Book
            {
                Title = "The Lord of the Rings",
                Author = "j.r.r. tolkien, John Ronald Reuel Tolkien",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2001, 1, 1),
                    Pages = 1176,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Mariner Books",
                    Description = @"Contains the complete set of the six books of Lord of the Rings."
                },
                Price = 27.82,
                Category = Category.Fantasy,
                RatingCount = 11,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/cbb53f9167aa781b5359ea7f8e22b4f6.jpg" }
                }
            },
    new Book
            {
                Title = "Lodestar",
                Author = "Shannon Messenger",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2016, 1, 1),
                    Pages = 688,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"Betrayed by one of their closest allies, Sophie&#x27;s whole word has been turned inside out. The battles are shaping up and the stakes have never been higher ..."
                },
                Price = 13.62,
                Category = Category.Fantasy,
                RatingCount = 353,
                Rating = 4.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/afa85b47f977f61922214ae2183bd88f.jpg" }
                }
            },
    new Book
            {
                Title = "The Dragonbone Chair",
                Author = "Tad Williams",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2005, 1, 1),
                    Pages = 674,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Penguin",
                    Description = @"Simon, a young kitchen boy and magician&#x27;s apprentice, finds his world torn apart by a civil war fueled by immortal enemies and the dark powers of sorcery."
                },
                Price = 10.18,
                Category = Category.Fantasy,
                RatingCount = 109,
                Rating = 4.2f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/ae1c2f92d4b69184b3e94c2eb38ac808.jpg" }
                }
            },
    new Book
            {
                Title = "The Wizard of Oz",
                Author = "L. Frank Baum",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2009, 1, 1),
                    Pages = 188,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Collector&#x27;s Library",
                    Description = @".0000000000This is the story of Dorothy and her little dog Toto, who are carried away from Kansas by a cyclone and transported to the wonderful world of Oz. She meets three companions - the Scarecrow, the Tin Woodman and the Cowardly Lion - and the three journey to the Emerald City of Oz to ask the ..."
                },
                Price = 6.56,
                Category = Category.Fantasy,
                RatingCount = 1,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/8232809a1582f5c76e1126a7ebb7d8b6.jpg" }
                }
            },
    new Book
            {
                Title = "Horton Hears a Who!",
                Author = "Dr. Seuss",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1982, 1, 1),
                    Pages = 76,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Random House Books for Young Readers",
                    Description = @"Originally copyrighted 1954, renewed 1982."
                },
                Price = 25.08,
                Category = Category.Fantasy,
                RatingCount = 702,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/59fbd4a167efd86426995e18220b876d.jpg" }
                }
            },
    new Book
            {
                Title = "Eragon",
                Author = "Christopher Paolini",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2006, 1, 1),
                    Pages = 770,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Laurel Leaf",
                    Description = @"14 Compact Discs; 16 hours, 23 minutes; unabridged Audio CD."
                },
                Price = 25.07,
                Category = Category.Fantasy,
                RatingCount = 5,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/14a60f2a6d239c479280c3aa1394d639.jpg" }
                }
            },
    new Book
            {
                Title = "The Wind in the Willows",
                Author = "Kenneth Grahame",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1993, 1, 1),
                    Pages = 202,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Wordsworth Editions",
                    Description = @"The escapades of four animal friends who live along a river in the English countryside--Toad, Mole, Rat, and Badger."
                },
                Price = 26.63,
                Category = Category.Fantasy,
                RatingCount = 7,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/6dd1bc9445f9c3c3fff565985b15b57c.jpg" }
                }
            },
    new Book
            {
                Title = "Guardians of the West",
                Author = "David Eddings",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1987, 1, 1),
                    Pages = 450,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Random House Digital, Inc.",
                    Description = @"Garion, the King of Riva, finds himself caught between the Dark Prophecy and the Prophecy of Light when he searches a previously obscure part of the Mrin Codex to identify someone or something called Zandramas."
                },
                Price = 17.61,
                Category = Category.Fantasy,
                RatingCount = 8,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/d621263b555edf5d267fa089472570b4.jpg" }
                }
            },
    new Book
            {
                Title = "The Illustrated Man",
                Author = "Ray Bradbury",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1951, 1, 1),
                    Pages = 264,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Spectra",
                    Description = @"Eighteen science fiction stories."
                },
                Price = 10.87,
                Category = Category.Fantasy,
                RatingCount = 4,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/d4791f0a0d5f1212751efbc86ab1ab2e.jpg" }
                }
            },
    new Book
            {
                Title = "Bridge to Terabithia",
                Author = "Katherine Paterson",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1979, 1, 1),
                    Pages = 148,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Avon Books",
                    Description = @"One of the most celebrated Newbery Medal winners of all time gets a magical makeover in this new edition, complete with a reader&#x27;s guide that&#x27;s ideal for teachers, book clubs, or anyone looking for insight into this favorite book."
                },
                Price = 15.63,
                Category = Category.Fantasy,
                RatingCount = 195,
                Rating = 4.3f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/82db804f409dda5ca043e239ea2ee8f8.jpg" }
                }
            },
    new Book
            {
                Title = "Throne of Glass",
                Author = "Sarah J. Maas",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2012, 1, 1),
                    Pages = 419,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Bloomsbury Publishing USA",
                    Description = @"After serving out a year of hard labor in the salt mines of Endovier for her crimes, 18-year-old assassin Celaena Sardothien is dragged before the Crown Prince. Prince Dorian offers her her freedom on one condition: she must act as his champion in a competition to find a new royal assassin. Her oppo..."
                },
                Price = 29.03,
                Category = Category.Fantasy,
                RatingCount = 7,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/482260e0c4d84280e24ce585ccaddbcc.jpg" }
                }
            },
    new Book
            {
                Title = "The Cat in the Hat",
                Author = "Dr. Seuss",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2012, 1, 1),
                    Pages = 73,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Random House Books for Young Readers",
                    Description = @"The Cat in the Hat entertains two children on a rainy day."
                },
                Price = 25.87,
                Category = Category.Fantasy,
                RatingCount = 14,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/b240223dabdab096c4bd3724e0784df9.jpg" }
                }
            },
    new Book
            {
                Title = "An Ember in the Ashes",
                Author = "Sabaa Tahir",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2020, 1, 1),
                    Pages = 482,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Razorbill",
                    Description = @"BOOK ONE IN THE NEW YORK TIMES BESTSELLING SERIES One of Time Magazine&#x27;s 100 Best Fantasy Books of All Time Instant New York Times bestseller From #1 New York Times bestselling author Sabaa Tahir Amazon&#x27;s Best Young Adult Book of 2015 People&#x27;s Choice Award winner - Favorite Fantasy Bu..."
                },
                Price = 7.1,
                Category = Category.Fantasy,
                RatingCount = 647,
                Rating = 4.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/844ff56abae4434d2038573423854ca8.jpg" }
                }
            },
    new Book
            {
                Title = "Harry Potter and the Deathly Hallows",
                Author = "J. K. Rowling",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2007, 1, 1),
                    Pages = 792,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"At a time when the forces of evil seem to be gaining the upper hand, Harry comes of age in the wizarding world, and must take on and defeat Voldemort--or be killed himself."
                },
                Price = 28.44,
                Category = Category.Fantasy,
                RatingCount = 92,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/af0d7e2fac9870d3d80ded2c95269886.jpg" }
                }
            },
    new Book
            {
                Title = "The Assassin&#x27;s Blade",
                Author = "Sarah J. Maas",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2014, 1, 1),
                    Pages = 465,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "A&amp;C Black",
                    Description = @"Celaena Sardothien is Adarlan&#x27;s most feared assassin. As part of the Assassins&#x27; Guild, her allegiance is to her master, Arobynn Hamel, yet Celaena listens to no one and trusts only her fellow killer-for-hire, Sam. In these action-packed prequel novellas - together in one edition for the fi..."
                },
                Price = 14.44,
                Category = Category.Fantasy,
                RatingCount = 1,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/6c4ebc27af4efb1005407567b59fb5e6.jpg" }
                }
            },
    new Book
            {
                Title = "The Borrowers",
                Author = "Mary Norton",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1953, 1, 1),
                    Pages = 196,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Houghton Mifflin Harcourt",
                    Description = @"Miniature people live in an old country house and provide for themselves by &quot;borrowing&quot; things from the humans until they are forced to emigrate from their home under the clock."
                },
                Price = 16.22,
                Category = Category.Fantasy,
                RatingCount = 12,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/c9f89832700980edf3ef8bc8fd30bcda.jpg" }
                }
            },
    new Book
            {
                Title = "The Ice Dragon",
                Author = "George R. R. Martin",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2014, 1, 1),
                    Pages = 130,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Macmillan",
                    Description = @"A tale of courage and sacrifice set in the world of the #1 New York Times bestselling series A Song of Ice and Fire, basis for HBO&#x27;s megahit Game of Thrones"
                },
                Price = 25.55,
                Category = Category.Fantasy,
                RatingCount = 83,
                Rating = 4.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/fce4257357b2fb486044aedb07bcb806.jpg" }
                }
            },
    new Book
            {
                Title = "Prince Caspian Movie Tie-in Edition (rack)",
                Author = "C. S. Lewis",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2008, 1, 1),
                    Pages = 260,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Zondervan",
                    Description = @"This movie tie-in edition of the full original PRINCE CASPIAN novel will be rack size, and feature a movie cover and an 8-page movie still insert."
                },
                Price = 13.29,
                Category = Category.Fantasy,
                RatingCount = 2,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/464070f4d48aab89c07063bdc43aed40.jpg" }
                }
            },
    new Book
            {
                Title = "A Wrinkle in Time",
                Author = "Madeleine L&#x27;Engle",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1973, 1, 1),
                    Pages = 240,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"This special edition ofA Wrinkle in Timeincludes a new essay that explores the science behind the fantasy. Rediscover one of the most beloved children&#x27;s books of all time:A Wrinkle in Timeby Madeleine L&#x27;Engle: Meg Murray, her little brother Charles Wallace, and their mother are having a mi..."
                },
                Price = 11.69,
                Category = Category.Fantasy,
                RatingCount = 3,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/76cbd9f043cf859e0d5b7a55fd85e4e2.jpg" }
                }
            },
    new Book
            {
                Title = "Moomin, Mymble and Little My",
                Author = "Tove Jansson",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2001, 1, 1),
                    Pages = 24,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"Finnish artist Tove Jansson&#x27;s Moomin stories have been continually in print for more than half a century, in 35 languages. They are among Europe&#x27;s best loved and enduring children&#x27;s classics, and through the TV animation (BBC2), the warm-hearted, whimsical creatures of Moomin valley h..."
                },
                Price = 11.12,
                Category = Category.Fantasy,
                RatingCount = 542,
                Rating = 4.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/ca1dde1ca64e567f9c36a2f485782589.jpg" }
                }
            },
    new Book
            {
                Title = "Legendborn",
                Author = "Tracy Deonn",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2022, 1, 1),
                    Pages = 544,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"Includes a short story from Selwyn Kane&#x27;s point of view."
                },
                Price = 18.03,
                Category = Category.Fantasy,
                RatingCount = 991,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/2a4c4dcb4d90acabcd0197a76b5c87d6.jpg" }
                }
            },
    new Book
            {
                Title = "Smith of Wootton Major",
                Author = "John Ronald Reuel Tolkien",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1967, 1, 1),
                    Pages = 72,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Boston : Houghton Mifflin",
                    Description = @"The author creates the magical story of the village of Wootton Major, which hosts a special feast every twenty-four years at which one fortunate citizen is admitted into the land of the Faery."
                },
                Price = 23.26,
                Category = Category.Fantasy,
                RatingCount = 668,
                Rating = 4.4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/93fea362a3a7332bf15693948d6a11f5.jpg" }
                }
            },
    new Book
            {
                Title = "The Tin Woodman of Oz",
                Author = "Lyman Frank Baum",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1918, 1, 1),
                    Pages = 316,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"Dorothy tries to rescue the Tin Woodman and Scarecrow from the giantess who has changed them into a tin owl and a teddy bear and is using them for playthings."
                },
                Price = 17.29,
                Category = Category.Fantasy,
                RatingCount = 392,
                Rating = 4.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/fdcb576a6bd01f942b71c22c6594d603.jpg" }
                }
            },
    new Book
            {
                Title = "The Lion, the Witch and the Wardrobe",
                Author = "Clive Staples Lewis, Pauline Baynes",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2001, 1, 1),
                    Pages = 202,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "HarperCollins Publishers",
                    Description = @"Four English school children enter the magic land of Narnia through the back of a wardrobe and assist Aslan, the golden lion, in defeating the White Witch who has cursed the land with eternal winter."
                },
                Price = 10.88,
                Category = Category.Fantasy,
                RatingCount = 1,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/3ab525d84ad56896baa286e9437419f5.jpg" }
                }
            },
    new Book
            {
                Title = "Tales from Earthsea",
                Author = "Ursula K. Le Guin",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2002, 1, 1),
                    Pages = 340,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Ace",
                    Description = @"Exploring the legend of Earthsea&#x27;s history, people, languages, literature, and magic, this collection of four magical stories is now available in a paperback edition."
                },
                Price = 8.8,
                Category = Category.Fantasy,
                RatingCount = 5,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/4dcd1da6a1d7dd6dfe1785dcf744e774.jpg" }
                }
            },
    new Book
            {
                Title = "Through the Looking-Glass",
                Author = "Lewis Carroll",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1993, 1, 1),
                    Pages = 248,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Harper Collins",
                    Description = @"Publisher description"
                },
                Price = 12.31,
                Category = Category.Fantasy,
                RatingCount = 77,
                Rating = 3.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/66038a30631a47e78625f4126f11ccff.jpg" }
                }
            },
    new Book
            {
                Title = "The Little Prince",
                Author = "Unknown",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2000, 1, 1),
                    Pages = 104,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Houghton Mifflin Harcourt",
                    Description = @"A man has an accident in the Sahara Desert, and encounters the Little Prince."
                },
                Price = 25.23,
                Category = Category.Fantasy,
                RatingCount = 50,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/0387af5b12fd0bcc017786e0dbfcf69f.jpg" }
                }
            },
    new Book
            {
                Title = "Peter Pan",
                Author = "J. M. Barrie",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2001, 1, 1),
                    Pages = 234,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"The adventures of Peter Pan, the boy who would not grow up."
                },
                Price = 18.13,
                Category = Category.Fantasy,
                RatingCount = 1,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/b1f7e8c5c5d12670675975e769ec11b9.jpg" }
                }
            },
    new Book
            {
                Title = "The Farthest Shore",
                Author = "Ursula K. Le Guin",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2012, 1, 1),
                    Pages = 272,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"When the prince of Enlad declares the wizards have forgotten their spells, Ged sets out to test the ancient prophecies of Earthsea."
                },
                Price = 27.62,
                Category = Category.Fantasy,
                RatingCount = 960,
                Rating = 3.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/a443bbdfb1e43a2fac6750dc092e94ed.jpg" }
                }
            },
    new Book
            {
                Title = "Where the Wild Things are",
                Author = "Maurice Sendak",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1963, 1, 1),
                    Pages = 46,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "HarperCollins Publishers",
                    Description = @"Max is sent to bed without supper and imagines sailing away to the land of Wild Things, where he is made king. Winner, 1964 Caldecott MedalNotable Children&#x27;s Books of 1940-1970 (ALA)1981 Boston Globe-Horn Book Award for Illustration1963, 1982 Fanfare Honor List (The Horn Book)Best Illustrated C..."
                },
                Price = 27.85,
                Category = Category.Fantasy,
                RatingCount = 529,
                Rating = 4.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/85e08ecb6494b2b330e9ffa407e87ad9.jpg" }
                }
            },
    new Book
            {
                Title = "House of Many Ways",
                Author = "Diana Wynne Jones",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2008, 1, 1),
                    Pages = 422,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Harper Collins",
                    Description = @"Charmain Baker is in over her head. Looking after Great-Uncle William&#x27;s tiny cottage while he&#x27;s ill should have been easy. But Great-Uncle William is better known as the Royal Wizard Norland, and his house bends space and time. Its single door leads to any number of places—the bedrooms, th..."
                },
                Price = 28.49,
                Category = Category.Fantasy,
                RatingCount = 10,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/00c0b0d551d406822e07164b0c1b60e2.jpg" }
                }
            },
    new Book
            {
                Title = "The Tombs of Atuan",
                Author = "Ursula K. Le Guin",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2012, 1, 1),
                    Pages = 224,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"&quot;With a new afterword from the author&quot;--Jkt."
                },
                Price = 20.74,
                Category = Category.Fantasy,
                RatingCount = 743,
                Rating = 3.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/9008608c286b4602ba926105647926e8.jpg" }
                }
            },
    new Book
            {
                Title = "Little Black Sambo",
                Author = "Helen Bannerman",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1921, 1, 1),
                    Pages = 72,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"The classic story by Helen Bannerman of a young Indian lad who meets up with a tiger and turns him into butter."
                },
                Price = 25.03,
                Category = Category.Fantasy,
                RatingCount = 811,
                Rating = 3.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/1de89f821191210e7ad6f02bd97abc6e.jpg" }
                }
            },
    new Book
            {
                Title = "The Talisman",
                Author = "Stephen King, Peter Straub",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1984, 1, 1),
                    Pages = 774,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"On a brisk autumn day, a thirteen-year-old boy stands on the shores of the gray Atlantic, near a silent amusement park and a fading ocean resort called the Alhambra. The past has driven Jack Sawyer here: his father is gone, his mother is dying, and the world no longer makes sense. But for Jack every..."
                },
                Price = 29.18,
                Category = Category.Fantasy,
                RatingCount = 20,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/8272250d7c098001c6c7dd398653a3a8.jpg" }
                }
            },
    new Book
            {
                Title = "The Black Cauldron",
                Author = "Lloyd Alexander",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1980, 1, 1),
                    Pages = 228,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Dell Publishing Company",
                    Description = @"&quot;Taran, the gallant Assistant Pig-keeper, and his companions once again fare forth to destroy the evil that threatens their beloved country, Prydain.... A wise and wondrous tale written in epic fashion.&quot; --Booklist"
                },
                Price = 21.51,
                Category = Category.Fantasy,
                RatingCount = 112,
                Rating = 4.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/48211ee24b8a99c753b9b4e159f725a2.jpg" }
                }
            },
    new Book
            {
                Title = "The Life and Adventures of Santa Claus",
                Author = "Lyman Frank Baum",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1902, 1, 1),
                    Pages = 268,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Castrovilli Giuseppe",
                    Description = @"A human foundling child, adopted by a wood-nymph and raised by the creatures who inhabit a magical forest, grows up to be the immortal Santa Claus."
                },
                Price = 10.8,
                Category = Category.Fantasy,
                RatingCount = 318,
                Rating = 4.2f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/4d066b804982a9ae719b3f2a4c112f2f.jpg" }
                }
            },
    new Book
            {
                Title = "There There",
                Author = "Tommy Orange",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2018, 1, 1),
                    Pages = 260,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Vintage",
                    Description = @"PULITZER PRIZE FINALIST • NATIONAL BESTSELLER • A wondrous and shattering award-winning novel that follows twelve characters from Native communities: all traveling to the Big Oakland Powwow, all connected to one another in ways they may not yet realize. A contemporary classic, this “astonishing lite..."
                },
                Price = 9.94,
                Category = Category.Fiction,
                RatingCount = 2,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/27cb1b66e1d7295a762b652985ea6b07.jpg" }
                }
            },
    new Book
            {
                Title = "The Plague",
                Author = "Albert Camus",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1991, 1, 1),
                    Pages = 322,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Vintage",
                    Description = @"“Its relevance lashes you across the face.” —Stephen Metcalf, The Los Angeles Times • “A redemptive book, one that wills the reader to believe, even in a time of despair.” —Roger Lowenstein, The Washington Post A haunting tale of human resilience and hope in the face of unrelieved horror, Albert Cam..."
                },
                Price = 25.9,
                Category = Category.Fiction,
                RatingCount = 14,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/6e8b432d8fc548122b13058e381c47c8.jpg" }
                }
            },
    new Book
            {
                Title = "Journey to the Center of the Earth",
                Author = "Jules Verne",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2006, 1, 1),
                    Pages = 242,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Bantam",
                    Description = @"The intrepid Professor Lindenbrock embarks upon the strangest expedition of the nineteenth century: a journey down an extinct Icelandic volcano to the Earth’s very core. In his quest to penetrate the planet’s primordial secrets, the geologist—together with his quaking nephew Axel and their devoted g..."
                },
                Price = 25.92,
                Category = Category.Fiction,
                RatingCount = 3,
                Rating = 3.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/a25f0543d97a32da75ceb62710d2e770.jpg" }
                }
            },
    new Book
            {
                Title = "Mysteries",
                Author = "Knut Hamsun",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2001, 1, 1),
                    Pages = 356,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Penguin",
                    Description = @"The first complete English translation of the Nobel Prize-winner’s literary masterpiece A Penguin Classic Mysteries is the story of Johan Nilsen Nagel, a mysterious stranger who suddenly turns up in a small Norwegian town one summer—and just as suddenly disappears. Nagel is a complete outsider, a so..."
                },
                Price = 13.7,
                Category = Category.Fiction,
                RatingCount = 3,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/4a2e733f8ca3d6e566281ed85775b293.jpg" }
                }
            },
    new Book
            {
                Title = "The Boleyn Inheritance",
                Author = "Philippa Gregory",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2008, 1, 1),
                    Pages = 596,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"THREE WOMEN WHO SHARE ONE FATE: THE BOLEYN INHERITANCE ANNE OF CLEVES She runs from her tiny country, her hateful mother, and her abusive brother to a throne whose last three occupants are dead. King Henry VIII, her new husband, instantly dislikes her. Without friends, family, or even an understandi..."
                },
                Price = 8.64,
                Category = Category.Fiction,
                RatingCount = 1,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/72dbbb0f10452fcb2840b3b364e0a8ef.jpg" }
                }
            },
    new Book
            {
                Title = "Netochka Nezvanova",
                Author = "Fyodor Dostoyevsky",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1986, 1, 1),
                    Pages = 0,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "National Geographic Books",
                    Description = @"Netochka Nezvanova - a &#x27;Nameless Nobody&#x27; - tells the story of a childhood dominated by her stepfather, Efimov, a failed musician who believes he is a neglected genius. The young girl is strangely drawn to this drunken ruin of a man, who exploits her and drives the family to poverty. But wh..."
                },
                Price = 11.71,
                Category = Category.Fiction,
                RatingCount = 57,
                Rating = 4.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/065e4502515e782dce3aa7390c6b60cc.jpg" }
                }
            },
    new Book
            {
                Title = "The Odyssey of Homer",
                Author = "Homer",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2005, 1, 1),
                    Pages = 559,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Bantam Classics",
                    Description = @"Homer&#x27;s epic chronicle of the Greek hero Odysseus&#x27; journey home from the Trojan War has inspired writers from Virgil to James Joyce. Odysseus survives storm and shipwreck, the cave of the Cyclops and the isle of Circe, the lure of the Sirens&#x27; song and a trip to the Underworld, only to..."
                },
                Price = 9.94,
                Category = Category.Fiction,
                RatingCount = 2,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/b760080da7db9a55ed2064dc9bd47379.jpg" }
                }
            },
    new Book
            {
                Title = "The Worship of the Serpent",
                Author = "John Bathurst Deane",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2020, 1, 1),
                    Pages = 395,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Library of Alexandria",
                    Description = @"No description available."
                },
                Price = 28.21,
                Category = Category.Fiction,
                RatingCount = 147,
                Rating = 5.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/3fa1c0a2ba4cb5536c889899b79b8106.jpg" }
                }
            },
    new Book
            {
                Title = "Pudd&#x27;nhead Wilson",
                Author = "Mark Twain",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2016, 1, 1),
                    Pages = 260,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"Enriched Classics offer readers accessible editions of great works of literature enhanced by helpful notes and commentary. Each book includes educational tools alongside the text, enabling students and readers alike to gain a deeper and more developed understanding of the writer and their work. Mark..."
                },
                Price = 13.59,
                Category = Category.Fiction,
                RatingCount = 939,
                Rating = 4.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/0a7a1494bd634a4a08588b82d68b1c88.jpg" }
                }
            },
    new Book
            {
                Title = "Dark Lover",
                Author = "J.R. Ward",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2014, 1, 1),
                    Pages = 3,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Penguin",
                    Description = @"Experience the start of J.R. Ward’s phenomenal #1 New York Times bestselling Black Dagger Brotherhood series. DON&#x27;T MISS PASSIONFLIX&#x27;S THE BLACK DAGGER BROTHERHOOD SERIES As the world’s only purebred vampire and the leader of the Black Dagger Brotherhood, Wrath has a score to settle with t..."
                },
                Price = 15.02,
                Category = Category.Fiction,
                RatingCount = 426,
                Rating = 3.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/a231ee50271eb9188e915b75f3b94d17.jpg" }
                }
            },
    new Book
            {
                Title = "Lucy Gayheart",
                Author = "Willa Cather",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2024, 1, 1),
                    Pages = 198,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "E-Kitap Projesi &amp; Cheapest Books",
                    Description = @"Willa Cather&#x27;s Lucy Gayheart gropes a wistful way back to the time of the horse and buggy, when some men and some women loved deeply and truly and make themselves miserable and hugged their misery. Small towns, no less than Vienna and the Paris Left Bank and a Greenwich Village as dirty and noi..."
                },
                Price = 23.1,
                Category = Category.Fiction,
                RatingCount = 611,
                Rating = 4.3f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/49ddd44d57cec26eee6b047e1f6ab197.jpg" }
                }
            },
    new Book
            {
                Title = "Taras Bulba",
                Author = "Nikolái V. Gogol",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2006, 1, 1),
                    Pages = 154,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Ediciones AKAL",
                    Description = @"Feroces, crueles, valientes y apasionados, los cosacos hacen temblar la estepa bajo los cascos de sus caballos. Y entre ellos se encuentra Taras Bulba, un anciano lleno aún de fuerza e inteligencia que junto a sus hijos, Ostap y Andrí, avanzará por tierras polacas con intención de vengar su fe ortod..."
                },
                Price = 20.51,
                Category = Category.Fiction,
                RatingCount = 309,
                Rating = 4.2f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/dbbbe9117ac023ad163703169a60a088.jpg" }
                }
            },
    new Book
            {
                Title = "Fallen Too Far",
                Author = "Abbi Glines",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2014, 1, 1),
                    Pages = 240,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"Blaire Wynn left her small farmhouse in Alabama after her mother passed away to move in with her father and his new wife in their sprawling beach house along the Florida Gulf Coast. She isn&#x27;t prepared for the lifestyle change and she knows she&#x27;ll never fit into this world. Then there&#x27;..."
                },
                Price = 7.85,
                Category = Category.Fiction,
                RatingCount = 1,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/94d1249aa2616ba3b1addae331d23eff.jpg" }
                }
            },
    new Book
            {
                Title = "Stories from the Pentamerone",
                Author = "Giambattista Basile",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2022, 1, 1),
                    Pages = 294,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "BoD – Books on Demand",
                    Description = @"Reproduction of the original."
                },
                Price = 27.47,
                Category = Category.Fiction,
                RatingCount = 404,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/2fb129a2fdc6601279ae5f691892595d.jpg" }
                }
            },
    new Book
            {
                Title = "THE Murder Of Roger Ackroyd",
                Author = "AGATHA CHRISTIE",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2024, 1, 1),
                    Pages = 314,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "ببلومانيا للنشر والتوزيع",
                    Description = @"Considered to be one of Agatha Christie&#x27;s greatest, and also most controversial mysteries, &#x27;The Murder Of Roger Ackroyd&#x27; breaks the rules of traditional mystery. The peaceful English village of King’s Abbot is stunned. The widow Ferrars dies from an overdose of Veronal. Not twenty-fou..."
                },
                Price = 8.82,
                Category = Category.Fiction,
                RatingCount = 815,
                Rating = 4.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/ada91cdb0ebf64bda0530563780418d8.jpg" }
                }
            },
    new Book
            {
                Title = "Uncle Tom’s Cabin (Volume 2 of 2) (EasyRead Large Edition)",
                Author = "Harriet Beecher Stowe",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2008, 1, 1),
                    Pages = 450,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "ReadHowYouWant.com",
                    Description = @"Stowes Uncle Toms Cabin (1852) is a powerful condemnation of slavery. With biblical references, she proves those wrong who contend that slavery is condoned in Christianity. The hardships faced by the Afro-Americans in order to survive are vivid and gut-wrenching, and Stowes female characters are rea..."
                },
                Price = 26.34,
                Category = Category.Fiction,
                RatingCount = 776,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/5bbe43d325bc190cc03df0e782e88c8a.jpg" }
                }
            },
    new Book
            {
                Title = "Sunset Park",
                Author = "Paul Auster",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2010, 1, 1),
                    Pages = 318,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Faber &amp; Faber",
                    Description = @"Auster&#x27;s novel of love and forgiveness from the author of contemporary classic The New York Trilogy: &#x27;a literary voice for the ages&#x27; ( Guardian) S unset Park is set in the sprawling flatlands of Florida, where twenty-eight-year-old Miles is photographing the last lingering traces of f..."
                },
                Price = 26.18,
                Category = Category.Fiction,
                RatingCount = 1,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/764e4a58e3c2b8102fd32c29b7eebebe.jpg" }
                }
            },
    new Book
            {
                Title = "The Trial",
                Author = "Franz Kafka",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1992, 1, 1),
                    Pages = 345,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Everyman&#x27;s Library",
                    Description = @"The story of the mysterious indictment, trial, and reckoning forced upon Joseph K—one of the twentieth century’s master parables from one of the greatest writers of the twentieth century, the author of The Metamorphosis. Translated by Willa and Edwin Muir The Trial reflects the central spiritual cri..."
                },
                Price = 14.37,
                Category = Category.Fiction,
                RatingCount = 312,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/40ad1587ee8ea6ed4f622d09d82ed2c6.jpg" }
                }
            },
    new Book
            {
                Title = "As Brave As You",
                Author = "Jason Reynolds",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2016, 1, 1),
                    Pages = 432,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"When two brothers decide to prove how brave they are, everything backfires--literally."
                },
                Price = 28.7,
                Category = Category.Fiction,
                RatingCount = 587,
                Rating = 4.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/b07be5aed4716e36d140327efad13cc3.jpg" }
                }
            },
    new Book
            {
                Title = "How to Stop Time",
                Author = "Matt Haig",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2018, 1, 1),
                    Pages = 352,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Penguin",
                    Description = @"From the New York Times bestselling author of The Midnight Library. “A quirky romcom dusted with philosophical observations….A delightfully witty…poignant novel.” —The Washington Post “She smiled a soft, troubled smile and I felt the whole world slipping away, and I wanted to slip with it, to go whe..."
                },
                Price = 24.53,
                Category = Category.Fiction,
                RatingCount = 1,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/b137a477e1654d22f753a51abcf575e1.jpg" }
                }
            },
    new Book
            {
                Title = "The Visitor",
                Author = "Lee Child",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2001, 1, 1),
                    Pages = 516,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Random House",
                    Description = @"&quot;Sergeant Amy Callan and Lieutenant Caroline Cook have a lot in common. Both were army high-flyers. Both were acquainted with Jack Reacher. Both were forced to resign from the service. Now they&#x27;re both dead. Both were found in their own home, naked, in a bath full of paint. Both apparent v..."
                },
                Price = 18.07,
                Category = Category.Fiction,
                RatingCount = 245,
                Rating = 4.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/29b49982d0b2680dc0a3ea8b3bebbdd4.jpg" }
                }
            },
    new Book
            {
                Title = "Frankenstein",
                Author = "Mary Shelley",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2023, 1, 1),
                    Pages = 234,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Good Press",
                    Description = @"Mary Shelley&#x27;s &#x27;Frankenstein&#x27; is a groundbreaking work of gothic literature that explores themes of ambition, isolation, and the consequences of playing god. Written in an epistolary format, the reader is drawn into the chilling tale of Victor Frankenstein and his creation, the monste..."
                },
                Price = 26.61,
                Category = Category.Fiction,
                RatingCount = 909,
                Rating = 4.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/2752fdce78797086ce8e2a54c21ee999.jpg" }
                }
            },
    new Book
            {
                Title = "Infinite Jest",
                Author = "David Foster Wallace",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1996, 1, 1),
                    Pages = 0,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Little, Brown",
                    Description = @"A gargantuan, mind-altering comedy about the Pursuit of Happiness in America set in an addicts&#x27; halfway house and a tennis academy, and featuring the most endearingly screwed-up family to come along in recent fiction, Infinite Jest explores essential questions about what entertainment is and wh..."
                },
                Price = 12.66,
                Category = Category.Fiction,
                RatingCount = 843,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/placeholder.jpg" }
                }
            },
    new Book
            {
                Title = "Sense and Sensibility - Illustrated Edition",
                Author = "Jane Austen",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2017, 1, 1),
                    Pages = 579,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Abela Publishing Ltd",
                    Description = @"SENSE AND SENSIBILITY written by Jane Austen with 41 illustrations by Hugh Thomson. When Elinor Dashwood&#x27;s father dies, her family&#x27;s finances are crippled. After the Dashwoods move to a cottage in Devonshire, Elinor&#x27;s sister Marianne is torn between the handsome John Willoughby and th..."
                },
                Price = 7.95,
                Category = Category.Fiction,
                RatingCount = 480,
                Rating = 4.2f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/6b3ee386d92f433ac5de42b4693808e0.jpg" }
                }
            },
    new Book
            {
                Title = "I, Tituba, Black Witch of Salem",
                Author = "Maryse Condé",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1994, 1, 1),
                    Pages = 260,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "One World/Ballantine",
                    Description = @"Blending the fictional with the factual, this highly praised novel ranges from the warm shores of seventeenth-century Barbados to the harsh realities of the slave trade, and the cold customs of Puritanical New England. It tells the story of Tituba, the only Black victim of the Salem witch trials and..."
                },
                Price = 21.86,
                Category = Category.Fiction,
                RatingCount = 1,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/9188bea7d001950dd35b25fc2e41b6bd.jpg" }
                }
            },
    new Book
            {
                Title = "The History of the Peloponnesian War",
                Author = "Thucydides",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2021, 1, 1),
                    Pages = 742,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Otbebookpublishing",
                    Description = @"The History of the Peloponnesian War (Greek: Ἱστορίαι, &quot;Histories&quot;) is a historical account of the Peloponnesian War (431–404 BC), which was fought between the Peloponnesian League (led by Sparta) and the Delian League (led by Athens). It was written by Thucydides, an Athenian historian wh..."
                },
                Price = 13.98,
                Category = Category.Fiction,
                RatingCount = 642,
                Rating = 4.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/9103c3f0978aeb062f3250a554115bc3.jpg" }
                }
            },
    new Book
            {
                Title = "The Street of Crocodiles",
                Author = "Bruno Schulz",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2020, 1, 1),
                    Pages = 136,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Rare Treasure Editions",
                    Description = @"&#x27;&#x27;The Street of Crocodiles&#x27;&#x27; by Bruno Schulz (1892-1942) was first published in Polish in 1934; this English translation was first published in the US by Walker and Company in 1963, public domain. A novel that blends the real and the fantastic, from &quot;one of the most original..."
                },
                Price = 27.46,
                Category = Category.Fiction,
                RatingCount = 436,
                Rating = 4.4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/f21f510a24221f6c0d41d178c3ea9db9.jpg" }
                }
            },
    new Book
            {
                Title = "My Struggle: Book 1",
                Author = "Karl Ove Knausgaard",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2013, 1, 1),
                    Pages = 382,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Macmillan + ORM",
                    Description = @"A New York Times bestseller, My Struggle: Book 1 introduces American readers to the audacious, addictive, and profoundly surprising international literary sensation that is the provocative and brilliant six-volume autobiographical novel by Karl Ove Knausgaard. It has already been anointed a Proustia..."
                },
                Price = 25.16,
                Category = Category.Fiction,
                RatingCount = 1,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/558e7240f6316df14e0f84a36d610b60.jpg" }
                }
            },
    new Book
            {
                Title = "SHERLOCK HOLMES - THE VALLEY OF FEAR",
                Author = "ARTHUR CONAN DOYLE",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2020, 1, 1),
                    Pages = 214,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "PURE SNOW PUBLISHING",
                    Description = @"SHERLOCK HOLMES – THE VALLEY OF FEAR, is the 4th and final novel written by Arthur Conan Doyle. This book is complete, unabridged and was originally published in 1915. This is one of Doyle’s most outstanding and well-known works of the adventures of the most famous crime-solving duo - Sherlock Holme..."
                },
                Price = 24.93,
                Category = Category.Fiction,
                RatingCount = 69,
                Rating = 3.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/4727e7fe4b823b4a6591b5500fea53a6.jpg" }
                }
            },
    new Book
            {
                Title = "Dreamcatcher",
                Author = "Stephen King",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2001, 1, 1),
                    Pages = 704,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"From master storyteller Stephen King comes his classic #1 New York Times bestseller about four friends who encounter evil in the Maine woods. Twenty-five years ago, in their haunted hometown of Derry, Maine, four boys bravely stood together and saved a mentally challenged child from vicious local bu..."
                },
                Price = 16.39,
                Category = Category.Fiction,
                RatingCount = 218,
                Rating = 4.3f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/f30e61def8239c3cd08187e3e21aae74.jpg" }
                }
            },
    new Book
            {
                Title = "Billy Bathgate",
                Author = "E. L. Doctorow",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1989, 1, 1),
                    Pages = 348,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "New York : Random House",
                    Description = @"Billy Bathgate is an urban Huck Finn who comes of age in New York City in the 1930s as the protege of Dutch Schultz, one of the most abominable gangsters of his time, but one of life&#x27;s great teachers as well. Copyright © Libri GmbH. All rights reserved."
                },
                Price = 13.79,
                Category = Category.Fiction,
                RatingCount = 692,
                Rating = 3.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/75a526d419af11bf4aef639966fd2519.jpg" }
                }
            },
    new Book
            {
                Title = "Sin and Its Consequences",
                Author = "Henry Edward",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2023, 1, 1),
                    Pages = 274,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "BoD – Books on Demand",
                    Description = @"Reprint of the original, first published in 1874. The publishing house Anatiposi publishes historical books as reprints. Due to their age, these books may have missing pages or inferior quality. Our aim is to preserve these books and make them available to the public so that they do not get lost."
                },
                Price = 22.83,
                Category = Category.Fiction,
                RatingCount = 359,
                Rating = 3.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/4db1209ae1bd4840cd13dcb3a79393c4.jpg" }
                }
            },
    new Book
            {
                Title = "A Connecticut Yankee in King Arthur&#x27;s Court Illustrated",
                Author = "Mark Twain",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2020, 1, 1),
                    Pages = 412,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Independently Published",
                    Description = @"A Connecticut Yankee in King Arthur&#x27;s Court is an 1889 novel by American humorist and writer Mark Twain. The book was originally titled A Yankee in King Arthur&#x27;s Court. Some early editions are titled A Yankee at the Court of King Arthur."
                },
                Price = 6.78,
                Category = Category.Fiction,
                RatingCount = 91,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/d4f5df07668402dd8a615ff01dbaa8ac.jpg" }
                }
            },
    new Book
            {
                Title = "The Scarred Woman",
                Author = "Jussi Adler-Olsen",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2018, 1, 1),
                    Pages = 481,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Penguin",
                    Description = @"The New York Times and #1 internationally bestselling author of The Keeper of Lost Causes delivers his most captivating and suspenseful Department Q novel yet—perfect for fans of Stieg Larsson. Detective Carl Mørck of Department Q, Copenhagen&#x27;s cold cases division, meets his toughest challenge ..."
                },
                Price = 14.0,
                Category = Category.Fiction,
                RatingCount = 233,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/a284b1f8bdfce2316e8e05c8179ed5f3.jpg" }
                }
            },
    new Book
            {
                Title = "The Final Problem",
                Author = "Arthur Conan Doyle",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2025, 1, 1),
                    Pages = 39,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "SAMPI Books",
                    Description = @"In &quot;The Final Problem&quot;, Sherlock Holmes finds himself locked in a dangerous battle of wits against Professor Moriarty, the mastermind behind London&#x27;s criminal underworld. Aware of the growing threat, Holmes and Watson flee to Switzerland in an attempt to evade Moriarty&#x27;s reach. A..."
                },
                Price = 28.15,
                Category = Category.Fiction,
                RatingCount = 884,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/393462cd3b422598835e4a5a656e2833.jpg" }
                }
            },
    new Book
            {
                Title = "Cat&#x27;s Cradle",
                Author = "Kurt Vonnegut",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1998, 1, 1),
                    Pages = 308,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Dial Press Trade Paperback",
                    Description = @"“A free-wheeling vehicle . . . an unforgettable ride!”—The New York Times Cat’s Cradle is Kurt Vonnegut’s satirical commentary on modern man and his madness. An apocalyptic tale of this planet’s ultimate fate, it features a midget as the protagonist, a complete, original theology created by a calyps..."
                },
                Price = 17.69,
                Category = Category.Fiction,
                RatingCount = 148,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/a94f87912ff974956a48ff0e719eae9b.jpg" }
                }
            },
    new Book
            {
                Title = "The Picture of Dorian Gray",
                Author = "Oscar Wilde",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2019, 1, 1),
                    Pages = 188,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Lulu.com",
                    Description = @"The Picture of Dorian Gray is the only published novel by Oscar Wilde, appearing as the lead story in Lippincott&#x27;s Monthly Magazine on 20 June 1890, printed as the July 1890 issue. The magazine&#x27;s editors feared the story was indecent as submitted, so they censored roughly 500 words, withou..."
                },
                Price = 19.88,
                Category = Category.Fiction,
                RatingCount = 277,
                Rating = 4.1f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/4acec798715d41982aa61afaec8e8e00.jpg" }
                }
            },
    new Book
            {
                Title = "A Connecticut Yankee in King Arthur&#x27;s Court",
                Author = "Mark Twain",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2014, 1, 1),
                    Pages = 340,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "CreateSpace",
                    Description = @"A Connecticut Yankee in King Arthur&#x27;s Court is an 1889 novel by American humorist and writer Mark Twain. The book was originally titled A Yankee in King Arthur&#x27;s Court. Some early editions are titled A Yankee at the Court of King Arthur."
                },
                Price = 9.72,
                Category = Category.Fiction,
                RatingCount = 144,
                Rating = 4.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/c1e844aab533d4f064db7b3d81751457.jpg" }
                }
            },
    new Book
            {
                Title = "The Metamorphosis",
                Author = "Franz Kafka",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2019, 1, 1),
                    Pages = 70,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"The Metamorphosis by Franz Kafka is a real classic. You should grab it and read it to experience it yourself. Here&#x27;s a simple plot to The Metamorphosis by Franz Kafka Gregor Samsa wakes up one morning to find himself transformed into a &quot;monstrous vermin&quot;. He initially considers the tr..."
                },
                Price = 7.43,
                Category = Category.Fiction,
                RatingCount = 143,
                Rating = 3.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/a38cf621b8e9172738d444886115322f.jpg" }
                }
            },
    new Book
            {
                Title = "The Song of Roland",
                Author = "Unknown",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2001, 1, 1),
                    Pages = 0,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "National Geographic Books",
                    Description = @"A contemporary prose rendering of the great medieval French epic, The Song of Roland is as canonical and significant as the Anglo-Saxon Beowulf. It extols the chivalric ideals in the France of Charlemagne through the exploits of Charlemagne&#x27;s nephew, the warrior Roland, who fights bravely to hi..."
                },
                Price = 6.93,
                Category = Category.Fiction,
                RatingCount = 547,
                Rating = 4.1f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/0b5ac8a17be3e1dfc1d7f3d9b7a0ca5e.jpg" }
                }
            },
    new Book
            {
                Title = "Science Fact and Science Fiction",
                Author = "Brian M. Stableford",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2006, 1, 1),
                    Pages = 758,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Taylor &amp; Francis",
                    Description = @"Publisher description"
                },
                Price = 22.79,
                Category = Category.SciFi,
                RatingCount = 1,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/88fffc5054d6369355ec82905f85c163.jpg" }
                }
            },
    new Book
            {
                Title = "Time in Fiction",
                Author = "Craig Bourne, Emily Caddick Bourne",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2016, 1, 1),
                    Pages = 280,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Oxford University Press",
                    Description = @"What can we learn about the world from engaging with fictional time-series-stories involving time travellers, recurring and rewinding time, and foreknowledge of the future? Craig Bourne and Emily Caddick Bourne show how we can use the complexities of fictional time to get to the core of the relation..."
                },
                Price = 14.77,
                Category = Category.SciFi,
                RatingCount = 697,
                Rating = 4.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/9c4ee79f3383d04cc087a51f76614489.jpg" }
                }
            },
    new Book
            {
                Title = "Worlds in Science Fiction",
                Author = "Pasquale De Marco",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2025, 1, 1),
                    Pages = 163,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Pasquale De Marco",
                    Description = @"In this captivating exploration of science fiction, we journey through the vast landscape of this beloved genre, delving into the science behind the stories, the impact of science fiction on society, and its enduring legacy. From the earliest tales of Jules Verne and H.G. Wells to the modern masterp..."
                },
                Price = 21.84,
                Category = Category.SciFi,
                RatingCount = 930,
                Rating = 4.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/63ab7c1caed6ebb0ca345e4e87dcaeac.jpg" }
                }
            },
    new Book
            {
                Title = "Fiction in French - Fiction in Soviet",
                Author = "British Library",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2013, 1, 1),
                    Pages = 464,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Walter de Gruyter",
                    Description = @"No detailed description available for &quot;Fiction in French - Fiction in Soviet&quot;."
                },
                Price = 16.4,
                Category = Category.SciFi,
                RatingCount = 414,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/486e999bbe7cbb63e6e8954419200be2.jpg" }
                }
            },
    new Book
            {
                Title = "The History of Science Fiction",
                Author = "A. Roberts",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2005, 1, 1),
                    Pages = 385,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Springer",
                    Description = @"The History of Science Fiction traces the origin and development of science fiction from Ancient Greece up to the present day. The author is both an academic literary critic and acclaimed creative writer of the genre. Written in lively, accessible prose it is specifically designed to bridge the worl..."
                },
                Price = 23.62,
                Category = Category.SciFi,
                RatingCount = 293,
                Rating = 4.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/3d0c44ed58ca9c0f2ef259301d0fded4.jpg" }
                }
            },
    new Book
            {
                Title = "Science Fiction Prototyping",
                Author = "Brian David Johnson",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2011, 1, 1),
                    Pages = 190,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Morgan &amp; Claypool Publishers",
                    Description = @"Science fiction is the playground of the imagination. If you are interested in science or fascinated with the future then science fiction is where you explore new ideas and let your dreams and nightmares duke it out on the safety of the page or screen. But what if we could use science fiction to do ..."
                },
                Price = 23.52,
                Category = Category.SciFi,
                RatingCount = 737,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/a3561ca52d78cc479571ff065c5721df.jpg" }
                }
            },
    new Book
            {
                Title = "Science Fiction and Climate Change",
                Author = "Andrew Milner, J. R. Burgmann",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2020, 1, 1),
                    Pages = 248,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"This is a timely, comprehensive and thoroughly researched study of climate fiction from around the world, including novels, short stories, films and other formats. Informed by a sociological perspective, it will be an invaluable resource for students and scholars looking to enter and expand the fiel..."
                },
                Price = 10.23,
                Category = Category.SciFi,
                RatingCount = 925,
                Rating = 4.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/79f52098f0ff9cfbb05dc861c0f67274.jpg" }
                }
            },
    new Book
            {
                Title = "Justice in Young Adult Speculative Fiction",
                Author = "Marek C. Oziewicz",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2015, 1, 1),
                    Pages = 246,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Routledge",
                    Description = @"This book is the first to offer a justice-focused cognitive reading of modern YA speculative fiction in its narrative and filmic forms. It links the expansion of YA speculative fiction in the 20th century with the emergence of human and civil rights movements, with the communitarian revolution in co..."
                },
                Price = 14.41,
                Category = Category.SciFi,
                RatingCount = 683,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/bcb1edad8d5fc1e017566265912efb9e.jpg" }
                }
            },
    new Book
            {
                Title = "(Eco)Anxiety in Nuclear Holocaust Fiction and Climate Fiction",
                Author = "Dominika Oramus",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2023, 1, 1),
                    Pages = 139,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Taylor &amp; Francis",
                    Description = @"(Eco)Anxiety in Nuclear Holocaust Fiction and Climate Fiction: Doomsday Clock Narratives demonstrates that disaster fiction— nuclear holocaust and climate change alike— allows us to unearth and anatomise contemporary psychodynamics and enables us to identify pretraumatic stress as the common denomin..."
                },
                Price = 10.95,
                Category = Category.SciFi,
                RatingCount = 493,
                Rating = 4.2f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/11e8cd3f3dd53b406fd27217c9d2afa2.jpg" }
                }
            },
    new Book
            {
                Title = "Cognitive Value of Philosophical Fiction",
                Author = "Jukka Mikkonen",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2013, 1, 1),
                    Pages = 234,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "A&amp;C Black",
                    Description = @"An examination of philosophical truth and knowledge in literary fiction."
                },
                Price = 9.36,
                Category = Category.SciFi,
                RatingCount = 772,
                Rating = 3.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/664568a7d97aa064fd7e276d16447c52.jpg" }
                }
            },
    new Book
            {
                Title = "Revising Fiction, Fact, and Faith",
                Author = "Nathaniel Goldberg, Chris Gavaler",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2020, 1, 1),
                    Pages = 194,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Routledge",
                    Description = @"This book addresses how our revisionary practices account for relations between texts and how they are read. It offers an overarching philosophy of revision concerning works of fiction, fact, and faith, revealing unexpected insights about the philosophy of language, the metaphysics of fact and ficti..."
                },
                Price = 28.77,
                Category = Category.SciFi,
                RatingCount = 335,
                Rating = 4.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/bfa65b0d7b09c22d3a7465be9df09a9b.jpg" }
                }
            },
    new Book
            {
                Title = "Ecofeminist Science Fiction",
                Author = "Douglas A. Vakoch",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2021, 1, 1),
                    Pages = 163,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Routledge",
                    Description = @"Ecofeminist Science Fiction: International Perspectives on Gender, Ecology, and Literature provides guidance in navigating some of the most pressing dangers we face today. Science fiction helps us face problems that threaten the very existence of humankind by giving us the emotional distance to see ..."
                },
                Price = 21.92,
                Category = Category.SciFi,
                RatingCount = 225,
                Rating = 4.4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/ff9dc95f268770a500fc4cb85737e126.jpg" }
                }
            },
    new Book
            {
                Title = "The Philosophy of Science Fiction Film",
                Author = "Steven Sanders",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2007, 1, 1),
                    Pages = 241,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "University Press of Kentucky",
                    Description = @"The science fiction genre maintains a remarkable hold on the imagination and enthusiasm of the filmgoing public, captivating large audiences worldwide and garnering ever-larger profits. Science fiction films entertain the possibility of time travel and extraterrestrial visitation and imaginatively t..."
                },
                Price = 10.83,
                Category = Category.SciFi,
                RatingCount = 2,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/9ec22879a364df8dc3fef440f868fd36.jpg" }
                }
            },
    new Book
            {
                Title = "Why We Read Fiction",
                Author = "Lisa Zunshine",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2006, 1, 1),
                    Pages = 210,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Ohio State University Press",
                    Description = @"Why We Read Fiction offers a lucid overview of the most exciting area of research in contemporary cognitive psychology known as &quot;Theory of Mind&quot; and discusses its implications for literary studies. It covers a broad range of fictional narratives, from Richardson s Clarissa, Dostoyevski&#x2..."
                },
                Price = 24.62,
                Category = Category.SciFi,
                RatingCount = 1,
                Rating = 3f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/e543c6c64f1eaba0e488e502747742e5.jpg" }
                }
            },
    new Book
            {
                Title = "Science fiction and innovation",
                Author = "Thomas Michaud",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2008, 1, 1),
                    Pages = 136,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "michaud",
                    Description = @"No description available."
                },
                Price = 15.28,
                Category = Category.SciFi,
                RatingCount = 424,
                Rating = 4.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/955fdf4df5e09b94663dfdf9237bba5f.jpg" }
                }
            },
    new Book
            {
                Title = "Science Fiction",
                Author = "Isaac Asimov, Greg Walz-Chojnacki, Francis Reddy",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1995, 1, 1),
                    Pages = 38,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Gareth Stevens Publishing",
                    Description = @"This book compares science fiction with science fact."
                },
                Price = 24.4,
                Category = Category.SciFi,
                RatingCount = 336,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/4f66b2bde693ae66204ea41406a6e1d5.jpg" }
                }
            },
    new Book
            {
                Title = "Fiction in American Magazines Before 1800",
                Author = "Edward W. R. Pitcher",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1993, 1, 1),
                    Pages = 344,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Union College Press",
                    Description = @"An easy-to-use identification manual for plants in eastern United States. Identification is through keys in which the matching of plant characteristics leads to family, genus, species and common name. The book also lists flowering dates, habitat and degree of rarity."
                },
                Price = 6.35,
                Category = Category.SciFi,
                RatingCount = 977,
                Rating = 3.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/65a999f67c9b67f77b36808c913c5aa9.jpg" }
                }
            },
    new Book
            {
                Title = "Music in Contemporary British Fiction",
                Author = "Gerry Smyth",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2008, 1, 1),
                    Pages = 264,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Palgrave MacMillan",
                    Description = @"Movie Watchers Guide to Enlightenment describes helpful movies in healing and Awakening to Truth."
                },
                Price = 19.13,
                Category = Category.SciFi,
                RatingCount = 927,
                Rating = 5.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/41f471d317dded871331ccdeb0310d02.jpg" }
                }
            },
    new Book
            {
                Title = "The Science in Science Fiction",
                Author = "Peter Nicholls",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1987, 1, 1),
                    Pages = 210,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Crescent",
                    Description = @"No description available."
                },
                Price = 28.77,
                Category = Category.SciFi,
                RatingCount = 130,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/d801ed3d4fbdd5a57aef7b2683b0a01a.jpg" }
                }
            },
    new Book
            {
                Title = "Science &amp; Technology in Fact and Fiction",
                Author = "DayAnn M. Kennedy, Stella S. Spangler, Mary Ann Vanderwerf",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1990, 1, 1),
                    Pages = 392,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "R. R. Bowker",
                    Description = @"Grade level: 8, 9, 10, 11, 12, i, s."
                },
                Price = 13.83,
                Category = Category.SciFi,
                RatingCount = 712,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/8aa3309bccc6b4af7a92bbbc6e20978b.jpg" }
                }
            },
    new Book
            {
                Title = "A Reader&#x27;s Guide to Australian Fiction",
                Author = "Laurie Clancy",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1992, 1, 1),
                    Pages = 392,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Oxford University Press, USA",
                    Description = @"This authoritative and comprehensive reference book is the first chronological account of the major Australian fiction writers from 1830 to the 1990s. Brief biographical information on the writers accompanies a critical discussion of the work. Each entry stands alone but the book can be read as a ch..."
                },
                Price = 16.75,
                Category = Category.SciFi,
                RatingCount = 703,
                Rating = 3.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/fb1984a3b5ac907871c382fff42dfc82.jpg" }
                }
            },
    new Book
            {
                Title = "The Supernatural and English Fiction",
                Author = "Glen Cavaliero",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1995, 1, 1),
                    Pages = 296,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Oxford University Press, USA",
                    Description = @"This book is the first ever to describe and discuss all the principal English writers who have handled the subject of the supernatural. Among those included in Glen Cavaliero&#x27;s absorbing study are James Hogg, Sheridan Le Fanu, Henry James, Rudyard Kipling, Walter de la Mare, M. R. James, John C..."
                },
                Price = 15.74,
                Category = Category.SciFi,
                RatingCount = 281,
                Rating = 4.4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/38af4695c20e4a500fb896dbd23b1d5a.jpg" }
                }
            },
    new Book
            {
                Title = "Space, Cosmology and Fiction",
                Author = "Joan Solomon",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1983, 1, 1),
                    Pages = 56,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Wiley-Blackwell",
                    Description = @"&quot;Space, Cosmology and Fiction begins with the confrontation between Galileo and the Church. It then follows some of the scientific discoveries which led to modern cosmology, to the excitement of science fiction, and to the present possibilities of space technology&quot;--Page 4 of cover."
                },
                Price = 23.14,
                Category = Category.SciFi,
                RatingCount = 484,
                Rating = 4.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/d8c894dcfbda1f0cb748c025565dcf20.jpg" }
                }
            },
    new Book
            {
                Title = "History and Fiction in Galdós&#x27;s Narratives",
                Author = "Geoffrey Ribbans",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1993, 1, 1),
                    Pages = 336,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Oxford University Press, USA",
                    Description = @"Galdos wrote prolifically in two distinct narrative modes: some twenty major &#x27;contemporary novels&#x27; in the realist tradition and a special sort of historical novel he called the episodio nacional. The reign of Isabella II (1843-68) and the revolutionary period which followed until 1875 was ..."
                },
                Price = 17.83,
                Category = Category.SciFi,
                RatingCount = 190,
                Rating = 4.4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/760dbe0fffc29ca4f3220dec143238d0.jpg" }
                }
            },
    new Book
            {
                Title = "Scientific American",
                Author = "Unknown",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1898, 1, 1),
                    Pages = 458,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 25.63,
                Category = Category.SciFi,
                RatingCount = 552,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/cb1da70818c3b188deeaaafba43e75c2.jpg" }
                }
            },
    new Book
            {
                Title = "Stranger Than Fiction",
                Author = "Melvin Berger",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1990, 1, 1),
                    Pages = 100,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"This account explores the world of killer bees, fire ants, &amp; other such bugs."
                },
                Price = 6.46,
                Category = Category.SciFi,
                RatingCount = 422,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/2e9b461b4b609e21229866caa818c75d.jpg" }
                }
            },
    new Book
            {
                Title = "Holt Anthology of Science Fiction",
                Author = "Holt Rinehart &amp; Winston",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2000, 1, 1),
                    Pages = 324,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Holt McDougal",
                    Description = @"Includes: an introduction to the genre of science fiction -- stories relating to the various areas of science by leading authors in the field -- Bibliographical information on authors -- References for additional reading -- Critical thinking questions."
                },
                Price = 25.65,
                Category = Category.SciFi,
                RatingCount = 71,
                Rating = 4.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/c2dea2133d177fdea2f27e0824037ae5.jpg" }
                }
            },
    new Book
            {
                Title = "Content-Based Chapter Books Fiction (Science: Planet Patrol): Antarctic Adventure",
                Author = "Rebecca L. Johnson",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2007, 1, 1),
                    Pages = 68,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "National Geographic Society",
                    Description = @"&quot;Four students travel to dry, icy Antarctica to study the AdeÌ1lie penguins. They use all they have learned to make an important rescue by themselves&quot;--Publisher&#x27;s website"
                },
                Price = 19.41,
                Category = Category.SciFi,
                RatingCount = 604,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/d2827dfd5569ba51a03bd160c5dbe4a4.jpg" }
                }
            },
    new Book
            {
                Title = "Fact, Fiction, and Forecast",
                Author = "Nelson Goodman",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1983, 1, 1),
                    Pages = 162,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"Here, in a new edition, is Nelson Goodman’s provocative philosophical classic—a book that, according to Science, “raised a storm of controversy” when it was first published in 1954, and one that remains on the front lines of philosophical debate. How is it that we feel confident in generalizing from..."
                },
                Price = 18.49,
                Category = Category.SciFi,
                RatingCount = 95,
                Rating = 3.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/2f4c4699131236f00ff9dd65884db5af.jpg" }
                }
            },
    new Book
            {
                Title = "Fact and Fiction in Modern Science",
                Author = "Henry Vincent Gill",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1944, 1, 1),
                    Pages = 152,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 24.04,
                Category = Category.SciFi,
                RatingCount = 612,
                Rating = 3.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/616a9c9004afa4c637968f80c69bad5d.jpg" }
                }
            },
    new Book
            {
                Title = "Saturday Review of Politics, Literature, Science and Art",
                Author = "Unknown",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1871, 1, 1),
                    Pages = 1188,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 9.66,
                Category = Category.SciFi,
                RatingCount = 737,
                Rating = 4.3f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/43a92764bb320a91e2baef424049d54c.jpg" }
                }
            },
    new Book
            {
                Title = "Ding Ling&#x27;s Fiction",
                Author = "Yi-tsi Mei Feuerwerker",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1982, 1, 1),
                    Pages = 222,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Harvard University Press",
                    Description = @"No description available."
                },
                Price = 13.03,
                Category = Category.SciFi,
                RatingCount = 921,
                Rating = 4.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/7f13c8576435156334fb87fcac22ac91.jpg" }
                }
            },
    new Book
            {
                Title = "Déliberations Et Mémoires de la Société Royale Du Canada",
                Author = "Royal Society of Canada",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1901, 1, 1),
                    Pages = 1018,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 27.16,
                Category = Category.SciFi,
                RatingCount = 717,
                Rating = 4.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/64ca02050e349e83a31491cd48a63097.jpg" }
                }
            },
    new Book
            {
                Title = "Lippincott&#x27;s Monthly Magazine",
                Author = "Unknown",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1874, 1, 1),
                    Pages = 784,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 10.72,
                Category = Category.SciFi,
                RatingCount = 276,
                Rating = 4.3f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/6f28a6aea51e3fb61960d157205215ab.jpg" }
                }
            },
    new Book
            {
                Title = "From Science Fiction to Science Facts",
                Author = "C. B. Don",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2005, 1, 1),
                    Pages = 142,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"&quot;FROM SCIENCE FICTION TO SCIENCE FACTS&quot; is the non-fiction companion study guide to the fantastic science-fiction novel, &quot;Accused By Facet-Eyes&quot;. It is a unique teaching/learning approach, which pairs literary entertainment with fascinating life science facts. Academic enrichment..."
                },
                Price = 21.12,
                Category = Category.SciFi,
                RatingCount = 1,
                Rating = 1f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/d95228fc8307f587fc9fc3cebd24e7be.jpg" }
                }
            },
    new Book
            {
                Title = "Colorado College Publication",
                Author = "Unknown",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1929, 1, 1),
                    Pages = 646,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 29.69,
                Category = Category.SciFi,
                RatingCount = 154,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/170a31d8ab7cc8931764599b21a2e135.jpg" }
                }
            },
    new Book
            {
                Title = "Science Fact and Science Fiction",
                Author = "Brian M. Stableford",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2006, 1, 1),
                    Pages = 758,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Taylor &amp; Francis",
                    Description = @"Publisher description"
                },
                Price = 29.99,
                Category = Category.SciFi,
                RatingCount = 1,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/88fffc5054d6369355ec82905f85c163.jpg" }
                }
            },
    new Book
            {
                Title = "Colorado College Publication",
                Author = "Colorado College",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1929, 1, 1),
                    Pages = 580,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 8.93,
                Category = Category.SciFi,
                RatingCount = 676,
                Rating = 4.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/170a31d8ab7cc8931764599b21a2e135.jpg" }
                }
            },
    new Book
            {
                Title = "Notices of the Proceedings",
                Author = "Royal Institution of Great Britain",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1887, 1, 1),
                    Pages = 634,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 21.83,
                Category = Category.SciFi,
                RatingCount = 232,
                Rating = 4.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/212fe2b20e70a7969702f6eb1eb49b4a.jpg" }
                }
            },
    new Book
            {
                Title = "Improvement of the Understanding",
                Author = "Benedictus de Spinoza",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1901, 1, 1),
                    Pages = 480,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 13.95,
                Category = Category.SciFi,
                RatingCount = 137,
                Rating = 5.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/51b697c1858f50595a284d99e77b16ba.jpg" }
                }
            },
    new Book
            {
                Title = "Abraham Lincoln",
                Author = "Michael Burlingame",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2013, 1, 1),
                    Pages = 1061,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "JHU Press",
                    Description = @"Now in paperback, this award-winning biography has been hailed as the definitive portrait of Lincoln. In the first multi-volume biography of Abraham Lincoln to be published in decades, Lincoln scholar Michael Burlingame offers a fresh look at the life of one of America’s greatest presidents. Incorpo..."
                },
                Price = 17.91,
                Category = Category.NonFiction,
                RatingCount = 730,
                Rating = 4.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/2f7cfa603df2a25fce27ad69cd4be673.jpg" }
                }
            },
    new Book
            {
                Title = "A Night to Remember",
                Author = "Walter Lord",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2005, 1, 1),
                    Pages = 209,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Macmillan",
                    Description = @"A cloth bag containing eight copies of the title."
                },
                Price = 26.06,
                Category = Category.NonFiction,
                RatingCount = 92,
                Rating = 3.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/7fe6417ac8b09e32b2e9c063404b52d5.jpg" }
                }
            },
    new Book
            {
                Title = "The Big Short: Inside the Doomsday Machine",
                Author = "Michael M. Lewis",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2011, 1, 1),
                    Pages = 287,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "W. W. Norton &amp; Company",
                    Description = @"The author examines the causes of the U.S. stock market crash of 2008 and its relation to overpriced real estate, bad mortgages, shareholder demand for excessive profits, and the growth of toxic derivatives."
                },
                Price = 27.27,
                Category = Category.NonFiction,
                RatingCount = 2,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/967d7b5c56cacefa7b994c0674e301fe.jpg" }
                }
            },
    new Book
            {
                Title = "AI Superpowers",
                Author = "Kai-Fu Lee",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2018, 1, 1),
                    Pages = 275,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Harper Business",
                    Description = @"AI Superpowers is Kai-Fu Lee&#x27;s New York Times and USA Today bestseller about the American-Chinese competition over the future of artificial intelligence."
                },
                Price = 6.6,
                Category = Category.NonFiction,
                RatingCount = 439,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/979735ee11baf8ffc29565eda6869c47.jpg" }
                }
            },
    new Book
            {
                Title = "Field Guide to Edible Wild Plants",
                Author = "Bradford Angier, David K. Foster",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2008, 1, 1),
                    Pages = 292,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"Provides an illustrated guide to North American wild edible plants. In this edition, Foster revises Angier&#x27;s foraging handbook, updating the taxonomy and adding more than a dozen species. Scientific information for a general audience and full-color illustrations combine with intriguing accounts..."
                },
                Price = 26.83,
                Category = Category.NonFiction,
                RatingCount = 584,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/9c3520f303fd954dd91b1a415dcc9572.jpg" }
                }
            },
    new Book
            {
                Title = "Tao Te Ching (Daodejing)",
                Author = "Laozi",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2018, 1, 1),
                    Pages = 370,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Viking Adult",
                    Description = @"A new &quot;translation of the ancient Chinese book of the Tao&quot;--Dust jacket front."
                },
                Price = 27.23,
                Category = Category.NonFiction,
                RatingCount = 630,
                Rating = 4.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/d501d618ba9313f0bbca23f9b9d7851e.jpg" }
                }
            },
    new Book
            {
                Title = "The Faithful Executioner",
                Author = "Joel F. Harrington",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2013, 1, 1),
                    Pages = 317,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Macmillan",
                    Description = @"&quot;A work of nonfiction that explores the thoughts and experiences of one early modern executioner, Nuremberg&#x27;s Frantz Schmidt (1555-1634), through his own words - a rare personal journal, in which he recorded and described all the executions and corporal punishments he administered between ..."
                },
                Price = 19.4,
                Category = Category.NonFiction,
                RatingCount = 844,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/6a88c1783a06315d9f53ab6745fd5ba9.jpg" }
                }
            },
    new Book
            {
                Title = "The TB12 Method",
                Author = "Tom Brady",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2017, 1, 1),
                    Pages = 320,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"The #1 New York Times bestseller by the 6-time Super Bowl champion The first book by New England Patriots quarterback Tom Brady--the 6-time Super Bowl champion who is still reaching unimaginable heights of excellence at 42 years old--a gorgeously illustrated and deeply practical &quot;athlete&#x27;s..."
                },
                Price = 22.1,
                Category = Category.NonFiction,
                RatingCount = 959,
                Rating = 3.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/c00c4feebdcca9f3b9efe51221ba8340.jpg" }
                }
            },
    new Book
            {
                Title = "Nonviolent Communication",
                Author = "Marshall B. Rosenberg",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2015, 1, 1),
                    Pages = 0,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Nonviolent Communication Guide",
                    Description = @"Psychologist Marshall Rosenberg lays out a communication and conflict-resolution process focusing on inspiring empathy and listening empathically."
                },
                Price = 19.68,
                Category = Category.NonFiction,
                RatingCount = 1,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/45aee74053da2063703084822a2c6914.jpg" }
                }
            },
    new Book
            {
                Title = "Mind Over Mood",
                Author = "Dennis Greenberger, Christine A. Padesky",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2015, 1, 1),
                    Pages = 367,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Guilford Publications",
                    Description = @"Discover simple yet powerful steps you can take to overcome emotional distress--and feel happier, calmer, and more confident. This life-changing book has already helped more than 1,300,000 readers use cognitive-behavioral therapy--one of today&#x27;s most effective forms of psychotherapy--to conquer..."
                },
                Price = 25.29,
                Category = Category.NonFiction,
                RatingCount = 462,
                Rating = 4.1f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/30eb262333bfea7fc7dbad06860ea397.jpg" }
                }
            },
    new Book
            {
                Title = "At My Table",
                Author = "Nigella Lawson",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2018, 1, 1),
                    Pages = 289,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"&quot;A celebration of home cooking in more than a hundred recipes: inspiring, achievable, and always delicious.&quot; -- page 4 of cover."
                },
                Price = 26.45,
                Category = Category.NonFiction,
                RatingCount = 141,
                Rating = 3.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/9ebe7c8d6b473722ae66e23250c26390.jpg" }
                }
            },
    new Book
            {
                Title = "Teach Your Child to Read in 100 Easy Lessons",
                Author = "Phyllis Haddox, Siegfried Engelmann, Elaine Bruner",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1986, 1, 1),
                    Pages = 416,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"A step-by-step program that shows parents, simply and clearly, how to teach their child to read in just 20 minutes a day."
                },
                Price = 13.06,
                Category = Category.NonFiction,
                RatingCount = 2,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/71cb1567c57829c4478af2c09d92f717.jpg" }
                }
            },
    new Book
            {
                Title = "The Seat of the Soul",
                Author = "Gary Zukav",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2014, 1, 1),
                    Pages = 384,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"Explores a new phase of human evolution that reflects a growing understanding about authentic, spiritual power based on cooperative beliefs and a reverence for life."
                },
                Price = 24.17,
                Category = Category.NonFiction,
                RatingCount = 904,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/2328448636a8585c6c26a13fe221ac5b.jpg" }
                }
            },
    new Book
            {
                Title = "How Not to Die",
                Author = "Michael Greger, Gene Stone",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2015, 1, 1),
                    Pages = 577,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Macmillan",
                    Description = @"Discover the foods scientifically proven to prevent and reverse disease."
                },
                Price = 16.77,
                Category = Category.NonFiction,
                RatingCount = 241,
                Rating = 4.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/a8c60e6fda2546b5c45c4c41c700b5fb.jpg" }
                }
            },
    new Book
            {
                Title = "Save the Cat!",
                Author = "Blake Snyder",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2005, 1, 1),
                    Pages = 0,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Michael Wiese Productions",
                    Description = @"« One of Hollywood&#x27;s most successful spec screenwriters tells all in this fast, funny, and candid look inside the movie business. &quot;Save the Cat&quot; is just one of many ironclad rules for making your ideas more marketable and your script more satisfying - and saleable. This ultimate insid..."
                },
                Price = 26.49,
                Category = Category.NonFiction,
                RatingCount = 1,
                Rating = 1f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/69d1845dd3f0c84385a09f3fcfcd0723.jpg" }
                }
            },
    new Book
            {
                Title = "Presidents of War",
                Author = "Michael R. Beschloss",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2018, 1, 1),
                    Pages = 786,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Crown Publishing Group (NY)",
                    Description = @"An intimate look at a procession of American leaders as they took the nation into conflict and mobilized their country for victory. From James Madison and the War of 1812 to Lyndon Johnson and Vietnam, we see these leaders struggling with Congress, the courts, the press, their own advisers, and anti..."
                },
                Price = 28.14,
                Category = Category.NonFiction,
                RatingCount = 846,
                Rating = 3.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/3f1b0ac2b3ab9b3515785e20728a3e65.jpg" }
                }
            },
    new Book
            {
                Title = "The Uninhabitable Earth",
                Author = "David Wallace-Wells",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2019, 1, 1),
                    Pages = 322,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"If your anxiety about global warming is dominated by fears of sea-level rise, you are barely scratching the surface of what terrors are possible. In California, wildfires now rage year-round; across the US storms pummel communities month after month. Wallace-Wells believes that, without a revolution..."
                },
                Price = 27.97,
                Category = Category.NonFiction,
                RatingCount = 591,
                Rating = 4.3f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/d69d8c071a5c060ac7b9b751950ad53a.jpg" }
                }
            },
    new Book
            {
                Title = "Chasing New Horizons",
                Author = "Alan Stern, David Grinspoon",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2018, 1, 1),
                    Pages = 316,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Picador",
                    Description = @"Shares a behind-the-scenes account of the science, politics, egos, and public expectations that shaped the New Horizons&#x27; mission to Pluto and beyond, citing the endeavor&#x27;s boundary-breaking achievements and how they reflect the collective power of shared human goals."
                },
                Price = 19.34,
                Category = Category.NonFiction,
                RatingCount = 922,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/bcdc5fba874cc797460696eab896e59b.jpg" }
                }
            },
    new Book
            {
                Title = "World War II at Sea",
                Author = "Craig L. Symonds",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2018, 1, 1),
                    Pages = 793,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Oxford University Press",
                    Description = @"Craig L. Symonds&#x27; World War II at Sea offers a definitive naval history of the Second World War presenting the chronology of the naval war, from The London Conference of 1930 to the surrender in Tokyo Bay in 1945, on a global scale for the first time."
                },
                Price = 10.24,
                Category = Category.NonFiction,
                RatingCount = 1,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/241b2877cabf98f8eedf2af97844a587.jpg" }
                }
            },
    new Book
            {
                Title = "Ben Hogan&#x27;s Five Lessons",
                Author = "Ben Hogan, Herbert Warren Wind",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1990, 1, 1),
                    Pages = 136,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"You can shoot in the 70&#x27;s!"
                },
                Price = 15.67,
                Category = Category.NonFiction,
                RatingCount = 3,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/10c0e7b6824122b9fc45158b791ac031.jpg" }
                }
            },
    new Book
            {
                Title = "In the Closet of The Vatican",
                Author = "Frédéric Martel",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2019, 1, 1),
                    Pages = 577,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Bloomsbury Publishing",
                    Description = @"The New York Times Bestseller&#x27;[An] earth-shaking exposé of clerical corruption&#x27; - National Catholic ReporterIn the Closet of the Vatican exposes the rot at the heart of the Vatican and the Roman Catholic Church today. This brilliant piece of investigative writing is based on four years&#x2..."
                },
                Price = 28.1,
                Category = Category.NonFiction,
                RatingCount = 727,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/b57f8c3e0b66b48ae3f3a398c9ee6537.jpg" }
                }
            },
    new Book
            {
                Title = "Narrative of the Life of Frederick Douglass, an American Slave",
                Author = "Frederick Douglass",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2014, 1, 1),
                    Pages = 228,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Penguin Classics",
                    Description = @"&quot;First published in the United States of America by The Anti-Slavery Office 1845&quot;--Title page verso."
                },
                Price = 18.83,
                Category = Category.NonFiction,
                RatingCount = 335,
                Rating = 4.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/f20215682aba968f486b66b000b576ae.jpg" }
                }
            },
    new Book
            {
                Title = "Undo It!",
                Author = "Dean Ornish MD, Dean Ornish, Anne Ornish",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2019, 1, 1),
                    Pages = 530,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"It works! -- Why it works-a unified theory of health and healing -- The lifestyle medicine revolution -- Eat well -- Move more -- Stress less -- Love more -- Ornish kitchen/true love recipes."
                },
                Price = 17.86,
                Category = Category.NonFiction,
                RatingCount = 402,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/4369e827625a41cfd35edc7ccaa91354.jpg" }
                }
            },
    new Book
            {
                Title = "Conservatism",
                Author = "Roger Scruton",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2018, 1, 1),
                    Pages = 175,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "All Points Books",
                    Description = @"Discusses the history and evolution of the conservative tradition through the centuries, and looks at how the writings of John Locke and Thomas Hobbes have influenced modern conservatives such as Ronald Reagan and Margaret Thatcher."
                },
                Price = 21.64,
                Category = Category.NonFiction,
                RatingCount = 518,
                Rating = 3.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/6ed17f2266a720508cd110c6086756fc.jpg" }
                }
            },
    new Book
            {
                Title = "My Country, My Life",
                Author = "Ehud Barak",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2018, 1, 1),
                    Pages = 495,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "St. Martin&#x27;s Press",
                    Description = @"&quot;One of Israel&#x27;s most influential and enduring figures, Ehud Barak was born on a kibbutz six years before the establishment of the state. During a long career in the military, he led the country&#x27;s elite special-forces unit and rose to become armed forces chief of staff before going on..."
                },
                Price = 10.38,
                Category = Category.NonFiction,
                RatingCount = 540,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/5de480b6d0ed27f6391a825af5c8c595.jpg" }
                }
            },
    new Book
            {
                Title = "Zucked",
                Author = "Roger McNamee",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2019, 1, 1),
                    Pages = 354,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"Pre-publication subtitle: The education of an unlikely activist."
                },
                Price = 14.57,
                Category = Category.NonFiction,
                RatingCount = 586,
                Rating = 4.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/f9752d688b12749af0f5391048573a50.jpg" }
                }
            },
    new Book
            {
                Title = "Ethics 101",
                Author = "Brian Boone",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2017, 1, 1),
                    Pages = 256,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"&quot;Ethics 101 offers an exciting look into the history of moral principles that dictate human behavior. This easy-to-read guide presents the key concepts of ethics in fun, straightforward lessons and exercises featuring only the most important facts, theories, and ideas. Ethics 101 includes uniqu..."
                },
                Price = 14.74,
                Category = Category.NonFiction,
                RatingCount = 548,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/56c63ed0be38ba1968f099d35c6c3c22.jpg" }
                }
            },
    new Book
            {
                Title = "The End of Everything",
                Author = "Katie Mack",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2021, 1, 1),
                    Pages = 256,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"Mack looks at five ways the universe could end, and the lessons each scenario reveals about the most important concepts in cosmology. --From publisher description."
                },
                Price = 12.42,
                Category = Category.NonFiction,
                RatingCount = 420,
                Rating = 4.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/2f237c884b7974cc1f8bbc127cae39d8.jpg" }
                }
            },
    new Book
            {
                Title = "The Indispensable Composers",
                Author = "Anthony Tommasini",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2018, 1, 1),
                    Pages = 498,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"In The Indispensable Composers, Tommasini offers his own personal guide to the canon - and what greatness really means in classical music. What does it mean to be canonical now? Who gets to say? And do we have enough perspective on the 20th century to even begin assessing it? Tommasini shares impres..."
                },
                Price = 21.61,
                Category = Category.NonFiction,
                RatingCount = 757,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/5f63eca783b46982529ae1402f5128cf.jpg" }
                }
            },
    new Book
            {
                Title = "Oh Crap! Potty Training",
                Author = "Jamie Glowacki",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2015, 1, 1),
                    Pages = 304,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"&quot;Toilet-training expert Jamie Glowacki&#x27;s self-published OH CRAP! POTTY TRAINING has sold more than 40,000 copies and has been the &quot;dirty little secret&quot; of moms on message boards and in parenting groups for years. Now, this proven, 6-step plan (called &quot;the WHAT TO EXPECT of p..."
                },
                Price = 8.4,
                Category = Category.NonFiction,
                RatingCount = 809,
                Rating = 4.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/9effe0b41b4355d9aef1c20c252d6205.jpg" }
                }
            },
    new Book
            {
                Title = "The Introvert&#x27;s Complete Career Guide",
                Author = "Jane Finkle",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2019, 1, 1),
                    Pages = 242,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"&quot;This handbook demonstrates how to use your introverted qualities to their best advantage, then add a few extroverted skills to round out a forceful combination for ultimate career success. Includes keys to navigating each stage of professional development--from self-assessment and job search t..."
                },
                Price = 21.85,
                Category = Category.NonFiction,
                RatingCount = 1,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/8b8eba70220ad6554eecb5222b49cada.jpg" }
                }
            },
    new Book
            {
                Title = "Dinner with Darwin",
                Author = "Jonathan Silvertown",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2017, 1, 1),
                    Pages = 241,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "University of Chicago Press",
                    Description = @"What do eggs, flour, and milk have in common? They form the basis of crepes of course, but they also each have an evolutionary purpose. Eggs, seeds (from which flour is derived by grinding) and milk are each designed by evolution to nourish offspring. Everything we eat has an evolutionary history. G..."
                },
                Price = 21.77,
                Category = Category.NonFiction,
                RatingCount = 332,
                Rating = 4.4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/506ed6ee138b52e95bbea36b97102c6f.jpg" }
                }
            },
    new Book
            {
                Title = "The Anti-Inflammation Diet and Recipe Book",
                Author = "Jessica K. Black, Jessica Black",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2006, 1, 1),
                    Pages = 258,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Hunter House",
                    Description = @"Explains the benefits of the anti-inflammatory diet with an accessible discussion of the science behind it. Offers many substitution suggestions and includes a healthy ingredient tip with each recipe. Most of the dishes can be prepared quickly and easily by even novice cooks."
                },
                Price = 13.94,
                Category = Category.NonFiction,
                RatingCount = 543,
                Rating = 4.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/366d93f621a0dc5cb08bfe0a9250064d.jpg" }
                }
            },
    new Book
            {
                Title = "Lonely Planet Vietnam",
                Author = "Iain Stewart",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2022, 1, 1),
                    Pages = 872,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Lonely Planet",
                    Description = @"Lonely Planet&#x27;s Vietnam is your passport to the most relevant, up-to-date advice on what to see and skip, and what hidden discoveries await you. Experience Hanois labyrinth-like Old Quarter, kayak in Halong Bay, and wander through historic Hoi An; all with your trusted travel companion. Get to..."
                },
                Price = 14.91,
                Category = Category.NonFiction,
                RatingCount = 225,
                Rating = 3.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/1a4e2195a947d65f81784c4ff363f09a.jpg" }
                }
            },
    new Book
            {
                Title = "The Covert Passive Aggressive Narcissist",
                Author = "Debbie Mirza",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2019, 1, 1),
                    Pages = 297,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"Do you feel confused and exhausted by a relationship, and you can&#x27;t figure out why?Do you feel like you can&#x27;t think straight, and the person in your life seems fine, so you wonder if maybe you are the problem?Has someone mentioned you might be with a narcissist, or you wonder yourself, but..."
                },
                Price = 19.1,
                Category = Category.NonFiction,
                RatingCount = 614,
                Rating = 4.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/placeholder.jpg" }
                }
            },
    new Book
            {
                Title = "The DevOps Handbook",
                Author = "Gene Kim, Patrick Debois, John Willis, Jez Humble",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2015, 1, 1),
                    Pages = 480,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "It Revolution Press",
                    Description = @"For decades, technology leaders have struggled to balance agility, reliability, and security, and the consequences of failure have never been greater. The effective management of technology is critical for business competitiveness. High-performing organizations are 2.5 times more likely to exceed pr..."
                },
                Price = 12.13,
                Category = Category.NonFiction,
                RatingCount = 379,
                Rating = 4.4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/a2ce25e46f7d765beb4afca3f48ae7be.jpg" }
                }
            },
    new Book
            {
                Title = "Black Klansman",
                Author = "Ron Stallworth",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2018, 1, 1),
                    Pages = 206,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"&quot;Soon to be a major motion picture&quot;--Cover."
                },
                Price = 27.27,
                Category = Category.NonFiction,
                RatingCount = 766,
                Rating = 4.3f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/95999deb3452eb4639d7502ced7a6b2c.jpg" }
                }
            },
    new Book
            {
                Title = "What to Say When You Talk to Your Self",
                Author = "Shad Helmstetter",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2017, 1, 1),
                    Pages = 224,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"Learn how to reverse the effects of negative self-talk and embrace a more positive, optimistic outlook on life"
                },
                Price = 27.28,
                Category = Category.NonFiction,
                RatingCount = 870,
                Rating = 4.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/e34d1e8f89fe2d4fdf9d3180a605af4f.jpg" }
                }
            },
    new Book
            {
                Title = "Galileo&#x27;s Middle Finger",
                Author = "Alice Dreger",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2016, 1, 1),
                    Pages = 370,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Penguin Books",
                    Description = @"&quot;Galileo&#x27;s Middle Finger is historian Alice Dreger&#x27;s eye-opening story of life in the trenches of scientific controversy. Dreger&#x27;s chronicle begins with her own research into the treatment of people born intersex (once called hermaphrodites). Realization of the shocking surgical ..."
                },
                Price = 6.41,
                Category = Category.NonFiction,
                RatingCount = 606,
                Rating = 4.1f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/8217fc74a69691296bd90e5c8bd0642f.jpg" }
                }
            },
    new Book
            {
                Title = "The Martha Manual",
                Author = "Martha Stewart",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2019, 1, 1),
                    Pages = 403,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Harvest",
                    Description = @"The time-tested, Martha-approved strategies in this book will help you organize, celebrate, clean, decorate... and any number of other life skills. -- adapted from back cover"
                },
                Price = 15.41,
                Category = Category.NonFiction,
                RatingCount = 562,
                Rating = 4.3f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/765376a1134670c18e21f599e9818964.jpg" }
                }
            },
    new Book
            {
                Title = "Fantastic Mr. Fox",
                Author = "Roald Dahl",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1998, 1, 1),
                    Pages = 98,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Puffin",
                    Description = @"The adventures of Mr. Fox and three mean farmers who want to destroy the fox and his family."
                },
                Price = 15.76,
                Category = Category.Adventure,
                RatingCount = 34,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/d227f0f059737ec0bb854f2eb38a242f.jpg" }
                }
            },
    new Book
            {
                Title = "The Jungle",
                Author = "Upton Sinclair",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1906, 1, 1),
                    Pages = 432,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "McLeod &amp; Allen",
                    Description = @"...Documents the brutal conditions in the Chicago stockyards at the turn of the century and brings into sharp moral focus the appalling odds against which immigrants and other working people struggled for their share in the American dream..."
                },
                Price = 27.51,
                Category = Category.Adventure,
                RatingCount = 1,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/c59d076ddf9d47dbffb709684cb6b559.jpg" }
                }
            },
    new Book
            {
                Title = "Look Homeward, Angel",
                Author = "Thomas Wolfe",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1929, 1, 1),
                    Pages = 644,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "New York, Modern Library [c1929]",
                    Description = @"Contains an introduction by the great editor Maxwell E. Perkins."
                },
                Price = 25.66,
                Category = Category.Adventure,
                RatingCount = 365,
                Rating = 5.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/879ff52dce419cb99abf521b22b372af.jpg" }
                }
            },
    new Book
            {
                Title = "White Fang",
                Author = "Jack London",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1906, 1, 1),
                    Pages = 346,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "New York ; London : Macmillan Company",
                    Description = @"No description available."
                },
                Price = 25.95,
                Category = Category.Adventure,
                RatingCount = 8,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/93be596e258dbaa1088952b84b84fda4.jpg" }
                }
            },
    new Book
            {
                Title = "The Long Patrol",
                Author = "Brian Jacques",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1998, 1, 1),
                    Pages = 372,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"Tenth Thrilling Redwall Adventure - New In Paperback! Damug Warfang, Head Of A Thousand Rapscallions - The Deadliest Horde Of Foebeasts Ever To Jump From Ship To Shore - Is Looking For Slaughter And Plunder. Can Any Beast Stand Against The Conqueror And His Savage Troops? Tammo&#x27;S Dream Comes Tr..."
                },
                Price = 15.12,
                Category = Category.Adventure,
                RatingCount = 511,
                Rating = 4.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/0c674d536c0346447e37df74c122d931.jpg" }
                }
            },
    new Book
            {
                Title = "White Fang and The Call of the Wild",
                Author = "Jack London",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1996, 1, 1),
                    Pages = 320,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Smithmark Publishers",
                    Description = @"No description available."
                },
                Price = 12.96,
                Category = Category.Adventure,
                RatingCount = 599,
                Rating = 4.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/b87eb3b698b874692d1ed64998e36eef.jpg" }
                }
            },
    new Book
            {
                Title = "The Ironwood Tree",
                Author = "Tony DiTerlizzi, Holly Black",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2004, 1, 1),
                    Pages = 140,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"After Mallory is kidnapped at her fencing meet, Jared and Simon search for her near an old quarry and find themselves amidst dwarves and goblins."
                },
                Price = 20.47,
                Category = Category.Adventure,
                RatingCount = 6,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/1450726fe3475aee4808b8842a2d1d5d.jpg" }
                }
            },
    new Book
            {
                Title = "Woodsong",
                Author = "Gary Paulsen",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2007, 1, 1),
                    Pages = 148,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"Three-time Newbery Honor author Gary Paulsen recounts the remarkable experiences that shaped his life and inspired his award-winning novels in this vividly detailed nonfiction middle grade book. Gary Paulsen is no stranger to adventure. He has flown off the back of a dogsled and down a frozen waterf..."
                },
                Price = 15.06,
                Category = Category.Adventure,
                RatingCount = 11,
                Rating = 3f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/c66b92264a88ebc0d0d3b15fcc047efa.jpg" }
                }
            },
    new Book
            {
                Title = "Treasure Island",
                Author = "Robert Louis Stevenson",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2004, 1, 1),
                    Pages = 276,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Collector&#x27;s Library",
                    Description = @"While going through the possessions of a deceased guest who owed them money, the mistress of the inn and her son find a treasure map that leads them to a pirate&#x27;s fortune."
                },
                Price = 23.33,
                Category = Category.Adventure,
                RatingCount = 1,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/8ae6e417a5fe16fa1be3bd2c6ac61840.jpg" }
                }
            },
    new Book
            {
                Title = "The Adventures of Tom Sawyer",
                Author = "Mark Twain",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1979, 1, 1),
                    Pages = 224,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Perfection Learning",
                    Description = @"ENDURING LITERATURE ILLUMINATED BY PRACTICAL SCHOLARSHIP A group of men set sail to solve the mystery of a sea monster in this amazing underwater adventure. EACH ENRICHED CLASSIC EDITION INCLUDES: - A concise introduction that gives readers important background information - A chronology of the auth..."
                },
                Price = 15.68,
                Category = Category.Adventure,
                RatingCount = 777,
                Rating = 4.1f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/placeholder.jpg" }
                }
            },
    new Book
            {
                Title = "The Mighty",
                Author = "Rodman Philbrick, W. Rodman Philbrick",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1993, 1, 1),
                    Pages = 188,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Scholastic",
                    Description = @"At the beginning of eighth grade, learning disabled Max and his new friend Freak, whose birth defect has affected his body but not his brilliant mind, find that when they combine forces they make a powerful team."
                },
                Price = 21.51,
                Category = Category.Adventure,
                RatingCount = 470,
                Rating = 4.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/74d193e418546638802804ed20a1a973.jpg" }
                }
            },
    new Book
            {
                Title = "Ghost Town at Sundown",
                Author = "Mary Pope Osborne",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2001, 1, 1),
                    Pages = 84,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Hippo Books",
                    Description = @"In this title, the 10th in the series, the Tree House house whisks Jack and Annie back to a ghost town in the Wild West of the 1880s. There are wild horses, wandering ghosts and rattlesnakes. Ann tames a lost colt and they meet a friendly stranger, but will he help them solve the second riddle?"
                },
                Price = 23.22,
                Category = Category.Adventure,
                RatingCount = 287,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/fc4682dc98401692151b500a6fd6e7e7.jpg" }
                }
            },
    new Book
            {
                Title = "Knights of the Kitchen Table",
                Author = "Jon Scieszka",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1993, 1, 1),
                    Pages = 68,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Puffin",
                    Description = @"Everyones favorite time-travelers are changing their style! &quot;The Time Warp Trio&quot; series now features a brand-new, eye-catching design, sure to appeal to longtime fans, and those new to Jon Scieszkas wacky brand of humor."
                },
                Price = 16.12,
                Category = Category.Adventure,
                RatingCount = 1,
                Rating = 3f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/d9374c550145f64b8e3f1f5f3160012c.jpg" }
                }
            },
    new Book
            {
                Title = "Hatchet",
                Author = "Gary Paulsen, Peter Coyote",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2004, 1, 1),
                    Pages = 0,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "National Geographic Books",
                    Description = @"After a plane crash, thirteen-year-old Brian spends fifty-four days in the wilderness, learning to survive with only the aid of a hatchet given him by his mother, and learning also to survive his parents&#x27; divorce."
                },
                Price = 24.28,
                Category = Category.Adventure,
                RatingCount = 191,
                Rating = 4.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/dc0cb51764a6d220fc314141ea68ebff.jpg" }
                }
            },
    new Book
            {
                Title = "Capt. Hook",
                Author = "J. V. Hart",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2007, 1, 1),
                    Pages = 372,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Harper Collins",
                    Description = @"With his long black curls, a shadowy family tree, and an affinity for pet spiders, James Matthew bears little resemblance to his starched-collar, blue-blooded peers at Eton. Dubbed King Jas., he stops at nothing to become the most notorious underclassman in the prestigious school&#x27;s history. For..."
                },
                Price = 9.33,
                Category = Category.Adventure,
                RatingCount = 1,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/639f352cdc511a5822fd2af5516f27b3.jpg" }
                }
            },
    new Book
            {
                Title = "River Boy",
                Author = "Tim Bowler",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2001, 1, 1),
                    Pages = 150,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Oxford University Press, USA",
                    Description = @"A new mass-market edition of this Carnegie Medal-winner. One of the classic teenage novels of the nineties, &quot;River Boy&quot; is an emotional, moving book which has had a profound influence on its readers. Following the story of Jess&#x27;s dying grandfather, and the marathon river swim Jess bec..."
                },
                Price = 12.06,
                Category = Category.Adventure,
                RatingCount = 2,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/fc2cfbd7775c3328d9bf68c42cd6b8ff.jpg" }
                }
            },
    new Book
            {
                Title = "Emil and the Detectives",
                Author = "Cyrus Harry Brooks, Erich Kästner",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1933, 1, 1),
                    Pages = 230,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"On his way to Berlin to visit his grandmother Emil fell asleep and had his money stolen by the man who shared his compartment. Although he came from the country Emil was not stupid, and he determined to get that money back. He followed the man, met the boy with the auto horn, who summoned his friend..."
                },
                Price = 19.5,
                Category = Category.Adventure,
                RatingCount = 884,
                Rating = 3.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/373b23d19fe9aeff26086cbfcf54c6b6.jpg" }
                }
            },
    new Book
            {
                Title = "The Angel Experiment",
                Author = "James Patterson",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2007, 1, 1),
                    Pages = 472,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "jimmy patterson",
                    Description = @"Max soars above the world . . . but in James Patterson&#x27;s thrilling adventure, fantasy can come crashing down to reveal the nightmares of the Angel Experiment. Maximum Ride and her &quot;flock&quot; -- Fang, Iggy, Nudge, Gasman and Angel -- are just like ordinary kids, only they have wings and c..."
                },
                Price = 28.4,
                Category = Category.Adventure,
                RatingCount = 4,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/6306f0225c7c8801287fc421c112d1a3.jpg" }
                }
            },
    new Book
            {
                Title = "The Count of Monte Cristo",
                Author = "Alexandre Damas",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2004, 1, 1),
                    Pages = 192,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"Presenting a delightful series of classics that will fascinate young readers. Written in simple langauge, these books retell the best-loved stories in literature in a way that will capture the child&#x27;s imagination. A fabulous way to introduce children to the wealth of classic literature!"
                },
                Price = 22.94,
                Category = Category.Adventure,
                RatingCount = 346,
                Rating = 4.3f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/placeholder.jpg" }
                }
            },
    new Book
            {
                Title = "Robinson Crusoe",
                Author = "Daniel Defoe, Anthony Masters",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2014, 1, 1),
                    Pages = 100,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Pacific Learning",
                    Description = @"Following a terrible storm, Crusoe finds himself stranded alone on a desert island off the coast of South America, all of his companions from his ship dead. Over the next 27 years, he builds a life for himself on the island, but is terribly lonely until he saves a Native American, who Crusoe calls F..."
                },
                Price = 12.67,
                Category = Category.Adventure,
                RatingCount = 288,
                Rating = 4.3f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/3da3ce694e95fc157eec5d9ec2078260.jpg" }
                }
            },
    new Book
            {
                Title = "Redwall",
                Author = "Brian Jacques",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1987, 1, 1),
                    Pages = 420,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Anchor",
                    Description = @"Seventh Trilling Redwall Adventure Redwall Abbey, Tranquil Home To A Community Of Peace-Loving Mice Is Threatened By Cluny The Scourge - The Evil-One-Eyed Rat Warlord -And His Battle-Hardened Horde Of Predators. Cluny Is Certain That Redwall Will Fall Easily To His Fearsome Army - But He Hasn&#x27;T..."
                },
                Price = 8.24,
                Category = Category.Adventure,
                RatingCount = 356,
                Rating = 4.1f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/d0136a95961717beb952f57e3d737f1a.jpg" }
                }
            },
    new Book
            {
                Title = "Hans Brinker",
                Author = "Unknown",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1988, 1, 1),
                    Pages = 52,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"A Dutch boy and girl work toward two goals, finding the doctor who can restore their father&#x27;s memory and winning the competition for the silver skates."
                },
                Price = 17.11,
                Category = Category.Adventure,
                RatingCount = 435,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/c37177d93803a8f6ee3b95c10e24ff65.jpg" }
                }
            },
    new Book
            {
                Title = "Tintin in America",
                Author = "Hergé",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2002, 1, 1),
                    Pages = 62,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Mammoth",
                    Description = @"The world’s most famous travelling reporter heads for America. Gangsters, Cowboys, Indians and the Big Apple await Tintin when he travels across the Atlantic to America. He soon finds himself in terrible danger - but with Snowy to help him, he faces it head on . . . Join the most iconic character in..."
                },
                Price = 18.09,
                Category = Category.Adventure,
                RatingCount = 781,
                Rating = 4.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/a0b7998ac74a7bb5b998448c24498268.jpg" }
                }
            },
    new Book
            {
                Title = "Tintin in America",
                Author = "Hergé",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2003, 1, 1),
                    Pages = 0,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Egmont Books Limited",
                    Description = @"The boy hero comes to the United States and triumphs over gangsters in Chicago of the 1930&#x27;s and the pitfalls of the wild West."
                },
                Price = 6.31,
                Category = Category.Adventure,
                RatingCount = 984,
                Rating = 4.3f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/a0b7998ac74a7bb5b998448c24498268.jpg" }
                }
            },
    new Book
            {
                Title = "The Magician&#x27;s Nephew",
                Author = "Clive Staples Lewis",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2005, 1, 1),
                    Pages = 274,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "HarperCollins UK",
                    Description = @"This edition of Lewis&#x27;s classic fantasy fiction is packaged specifically for adults. Complementing the look of the author&#x27;s non-fiction books, and anticipating the forthcoming Narnia feature films, this edition contains an exclusive P.S. section about the history of the book, plus a sample..."
                },
                Price = 28.98,
                Category = Category.Adventure,
                RatingCount = 464,
                Rating = 4.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/9bbe327293b0c1dcc59ede7c5618e6cf.jpg" }
                }
            },
    new Book
            {
                Title = "Harry Potter and the Chamber of Secrets",
                Author = "J. K. Rowling",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1998, 1, 1),
                    Pages = 251,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Bloomsbury Press",
                    Description = @"Sequel to Harry Potter and the sorcerer&#x27;s stone. When the chamber of secrets is opened again at the Hogswart School for witchcraft and wizardry, second-year student Harry Potter finds himself in danger from a dark power that has once more been released on the school."
                },
                Price = 18.63,
                Category = Category.Adventure,
                RatingCount = 53,
                Rating = 3.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/e3c5e19079819a6703804ce0cd50d5d5.jpg" }
                }
            },
    new Book
            {
                Title = "The Wizard of Oz",
                Author = "Lyman Frank Baum",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1956, 1, 1),
                    Pages = 252,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"After a cyclone transports her to the land of Oz, Dorothy must seek out the great wizard in order to return to Kansas."
                },
                Price = 8.02,
                Category = Category.Adventure,
                RatingCount = 869,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/8232809a1582f5c76e1126a7ebb7d8b6.jpg" }
                }
            },
    new Book
            {
                Title = "Percy Jackson and the Greek Gods",
                Author = "Rick Riordan",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2015, 1, 1),
                    Pages = 0,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Puffin",
                    Description = @"A publisher in New York asked me to write down what I know about the Greek gods, and I was like, Can we do this anonymously? Because I don&#x27;t need the Olympians mad at me again. But if it helps you to know your Greek gods, and survive an encounter with them if they ever show up in your face, the..."
                },
                Price = 22.61,
                Category = Category.Adventure,
                RatingCount = 707,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/6540d2847f4c3716e92bc5082f6b888f.jpg" }
                }
            },
    new Book
            {
                Title = "Ark Angel",
                Author = "Anthony Horowitz",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2006, 1, 1),
                    Pages = 342,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"After recovering from a near fatal gunshot wound, teenage spy Alex Rider embarks on a new mission to stop a group of eco-terrorists from sabotaging the launch of the first outer space hotel."
                },
                Price = 9.89,
                Category = Category.Adventure,
                RatingCount = 910,
                Rating = 5.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/ff3b1833e54fd7cde567c1bc66f44abf.jpg" }
                }
            },
    new Book
            {
                Title = "The Lost World",
                Author = "Michael Crichton",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1995, 1, 1),
                    Pages = 0,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Vintage",
                    Description = @"With the highest grossing film in cinema history, Jurassic Park invented the word dinomania which swept the country in 1993. Now, the events prefaced in the epilogue to that novel are explored in this sequel."
                },
                Price = 23.48,
                Category = Category.Adventure,
                RatingCount = 948,
                Rating = 4.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/c443f093680c2efe2880c62614750409.jpg" }
                }
            },
    new Book
            {
                Title = "Treasure Island",
                Author = "Robert Louis Stevenson",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1897, 1, 1),
                    Pages = 0,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"While going through the possessions of a deceased guest who owed them money, the mistress of the inn and her son find a treasure map that leads them to a pirate&#x27;s fortune."
                },
                Price = 29.08,
                Category = Category.Adventure,
                RatingCount = 851,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/placeholder.jpg" }
                }
            },
    new Book
            {
                Title = "The Wanderer",
                Author = "Sharon Creech",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2001, 1, 1),
                    Pages = 244,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Pan Macmillan",
                    Description = @"Sophie is about to embark on the most exciting voyage of her life - crossing the Atlantic from Connecticut to Ireland in her uncle&#x27;s yacht, The Wanderer. Best of all, at the end of the journey, she&#x27;ll be reunited with her beloved grandfather, Bompie."
                },
                Price = 10.57,
                Category = Category.Adventure,
                RatingCount = 1,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/5eafdb806fdf75e3a1482a40b8f6e3ff.jpg" }
                }
            },
    new Book
            {
                Title = "Treasure Island",
                Author = "Robert Louis Stevenson",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1993, 1, 1),
                    Pages = 0,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Macmillan Children&#x27;s Books",
                    Description = @"No description available."
                },
                Price = 14.99,
                Category = Category.Adventure,
                RatingCount = 415,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/8ae6e417a5fe16fa1be3bd2c6ac61840.jpg" }
                }
            },
    new Book
            {
                Title = "Swiss Family Robinson",
                Author = "Johann David Wyss",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1994, 1, 1),
                    Pages = 192,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Godfrey Cave Associates",
                    Description = @"No description available."
                },
                Price = 14.38,
                Category = Category.Adventure,
                RatingCount = 882,
                Rating = 4.3f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/def8d499f7225ea278f4c029eb8cccf6.jpg" }
                }
            },
    new Book
            {
                Title = "Harry Potter and the Prisoner of Azkaban",
                Author = "J. K. Rowling",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1999, 1, 1),
                    Pages = 317,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Bloomsbury Publishing",
                    Description = @"When Harry and his best friends go back for their third year at Hogwarts, the atmosphere is tense. There&#x27;s an escaped mass-murderer on the loose and the sinister prison guards of Azkaban have been called in to guard the school. Lessons, however, must go on and there are lots of new subjects in ..."
                },
                Price = 7.82,
                Category = Category.Adventure,
                RatingCount = 3,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/30f8b46d900cee32bf8b8c6859f27416.jpg" }
                }
            },
    new Book
            {
                Title = "The Boy in the Striped Pyjamas",
                Author = "John Boyne",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2007, 1, 1),
                    Pages = 0,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Oxford University Press, USA",
                    Description = @"Berlin 1942. When Bruno returns home from school one day, he discovers that his belongings are being packed in crates. His father has received a promotion and the family must move from their home to a new house far far away, where there is no one to play with and nothing to do. A tall fence running ..."
                },
                Price = 6.88,
                Category = Category.Adventure,
                RatingCount = 4,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/3597a65c0975a84a2244507ee90a57ef.jpg" }
                }
            },
    new Book
            {
                Title = "Beyond the Grave",
                Author = "Jude Watson",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2009, 1, 1),
                    Pages = 190,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Scholastic Press",
                    Description = @"A clue takes Amy and Dan Cahill to Egypt, where they investigate the origins of the rivalry between the Tomas and Ekaterina branches of their family and try to figure out if they can trust a message from their dead grandmother Grace."
                },
                Price = 7.32,
                Category = Category.Adventure,
                RatingCount = 299,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/7e4f5beb4988d0d5c6d81eb93b10adb8.jpg" }
                }
            },
    new Book
            {
                Title = "The World of Pooh Collection",
                Author = "Alan Alexander Milne",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2000, 1, 1),
                    Pages = 144,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Methuen Childrens Books",
                    Description = @"The story of Winnie-the-Pooh and his friends Piglet, Christopher Robin, Piglet, Rabbit and Owl, Kanga and Roo - not forgetting Eeyore - and their adventures in the Hundred Acre Wood."
                },
                Price = 28.22,
                Category = Category.Adventure,
                RatingCount = 247,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/placeholder.jpg" }
                }
            },
    new Book
            {
                Title = "The Colossus Rises",
                Author = "Peter Lerangis",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2013, 1, 1),
                    Pages = 256,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"The day after 12-year-old Jack McKinley is told he has six months to live, he awakens on a mysterious island, where a secret organization promises to save his life - but with one condition. With his three friends, Jack must lead a mission to retrieve seven lost magical orbs, which, only when combine..."
                },
                Price = 28.54,
                Category = Category.Adventure,
                RatingCount = 107,
                Rating = 3.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/ce3122cec2cb44a4541e0415d501df3c.jpg" }
                }
            },
    new Book
            {
                Title = "The Will of the Empress",
                Author = "Tamora Pierce",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2008, 1, 1),
                    Pages = 0,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Scholastic Paperbacks",
                    Description = @"This is the final book in the Circle series. The four young mages, Tris, Sandry, Briar and Daja are now young adults and are back together."
                },
                Price = 21.32,
                Category = Category.Adventure,
                RatingCount = 3,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/6420a5444008bfe0cad3d053dbd36514.jpg" }
                }
            },
    new Book
            {
                Title = "The Hemingses of Monticello",
                Author = "Annette Gordon-Reed",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2008, 1, 1),
                    Pages = 824,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "W. W. Norton &amp; Company",
                    Description = @"Historian and legal scholar Gordon-Reed presents this epic work that tells the story of the Hemingses, an American slave family and their close blood ties to Thomas Jefferson."
                },
                Price = 17.13,
                Category = Category.Biography,
                RatingCount = 4,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/a62380e25b36f21398f04826ae3859a1.jpg" }
                }
            },
    new Book
            {
                Title = "Eat, Pray, Love",
                Author = "Elizabeth Gilbert",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2007, 1, 1),
                    Pages = 385,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "A&amp;C Black",
                    Description = @"The Number One international bestseller, Eat, Pray Love is a journey around the world, a quest for spiritual enlightenment and a story for anyone who has battled with divorce, depression and heartbreak."
                },
                Price = 17.83,
                Category = Category.Biography,
                RatingCount = 2,
                Rating = 3.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/b8de37dff6934069b9dd67ab1a5cb6c7.jpg" }
                }
            },
    new Book
            {
                Title = "What Are the Gospels?",
                Author = "Richard A. Burridge",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2004, 1, 1),
                    Pages = 384,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Wm. B. Eerdmans Publishing",
                    Description = @"&quot;The publication of Richard Burridge&#x27;s What Are the Gospels? in 1992 inaugurated a transformation in Gospel studies by overturning the previous consensus about Gospel uniqueness. Burridge argued convincingly for an understanding of the Gospels as biographies, a ubiquitous genre in the Grae..."
                },
                Price = 27.77,
                Category = Category.Biography,
                RatingCount = 274,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/9dfe3e1785cfb035991ebaa44d41a914.jpg" }
                }
            },
    new Book
            {
                Title = "Einstein",
                Author = "Walter Isaacson",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2017, 1, 1),
                    Pages = 704,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"From Isaacson, the bestselling author of &quot;Benjamin Franklin,&quot; comes the first full biography of Albert Einstein since all his papers have become available--a fully realized portrait of a premier icon of his era."
                },
                Price = 27.48,
                Category = Category.Biography,
                RatingCount = 212,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/654a9672469401ce8348a194f7c5e329.jpg" }
                }
            },
    new Book
            {
                Title = "The Lord of Uraniborg",
                Author = "Victor E. Thoren, John Robert Christianson",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1990, 1, 1),
                    Pages = 537,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Cambridge University Press",
                    Description = @"The Lord of Uraniborg is a comprehensive biography of Tycho Brahe, father of modern astronomy, famed alchemist and littérateur of the sixteenth-century Danish Renaissance. Written in a lively and engaging style, Victor Thoren&#x27;s biography offers interesting perspectives on Tycho&#x27;s life and ..."
                },
                Price = 25.77,
                Category = Category.Biography,
                RatingCount = 125,
                Rating = 4.4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/b8bebda03bff9877f5cdae5f21655bad.jpg" }
                }
            },
    new Book
            {
                Title = "Furiously Happy",
                Author = "Jenny Lawson",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2015, 1, 1),
                    Pages = 352,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Macmillan",
                    Description = @"&quot;In Furiously Happy...Jenny Lawson explores her lifelong battle with mental illness&quot;--"
                },
                Price = 14.4,
                Category = Category.Biography,
                RatingCount = 1,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/a9b3cdf3fee42a94bf35df086e84b517.jpg" }
                }
            },
    new Book
            {
                Title = "Tuesdays with Morrie",
                Author = "Mitch Albom",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1997, 1, 1),
                    Pages = 216,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Doubleday",
                    Description = @"An old man, a young man, and life&#x27;s greatest lesson."
                },
                Price = 19.94,
                Category = Category.Biography,
                RatingCount = 603,
                Rating = 4.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/89eb2f0c3096654b6c53d5d2131586c2.jpg" }
                }
            },
    new Book
            {
                Title = "The Yellow House",
                Author = "Sarah M. Broom",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2019, 1, 1),
                    Pages = 304,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Grove Press",
                    Description = @"A brilliant, haunting and unforgettable memoir from a stunning new talent about the inexorable pull of home and family, set in a shotgun house in New Orleans East."
                },
                Price = 13.67,
                Category = Category.Biography,
                RatingCount = 381,
                Rating = 3.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/fa5552c488f33d95184e344642bc7a89.jpg" }
                }
            },
    new Book
            {
                Title = "I Know why the Caged Bird Sings",
                Author = "Maya Angelou",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1993, 1, 1),
                    Pages = 264,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Bantam",
                    Description = @"The moving and beautiful autobiography of a talented black woman. &quot;. . . I have no words for this achievement, but I know that not since the days of my childhood . . . have I found myself so moved . . . Her portrait is a Biblical study of life in the midst of death&quot;.--James Baldwin. Copyri..."
                },
                Price = 12.1,
                Category = Category.Biography,
                RatingCount = 606,
                Rating = 4.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/cc59f814d5427c8ee6229fe92de50319.jpg" }
                }
            },
    new Book
            {
                Title = "Team of Rivals",
                Author = "Doris Kearns Goodwin",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2012, 1, 1),
                    Pages = 944,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"Presents an overview of the presidency of Abraham Lincoln, explaining the genius of his political savvy, and describes the context in which he assigned a cadre of his fiercest rivals as his closest cabinet advisors."
                },
                Price = 11.6,
                Category = Category.Biography,
                RatingCount = 430,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/b0710e9f92fa1381409fbbbe349bbb0f.jpg" }
                }
            },
    new Book
            {
                Title = "John Adams",
                Author = "David McCullough",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2001, 1, 1),
                    Pages = 18,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"Profiles John Adams, an influential patriot during the American Revolution who became the nation&#x27;s first vice president and second president."
                },
                Price = 26.78,
                Category = Category.Biography,
                RatingCount = 21,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/d8f818806fa0d6b6a23b2eaed96b081b.jpg" }
                }
            },
    new Book
            {
                Title = "The Fight of His Life",
                Author = "Chris Whipple",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2023, 1, 1),
                    Pages = 416,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"Taking readers behind the scenes of one of America&#x27;s administrations, a journalist with unprecedented access to the White House reveals how President Joe Biden and his team deliver their agenda."
                },
                Price = 15.89,
                Category = Category.Biography,
                RatingCount = 825,
                Rating = 5.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/1634ece1d04b3c4e288eeabc9f10e677.jpg" }
                }
            },
    new Book
            {
                Title = "Clara Bow",
                Author = "David Stenn",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2000, 1, 1),
                    Pages = 402,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Rowman &amp; Littlefield",
                    Description = @"Hollywood&#x27;s first sex symbol, the &#x27; It &#x27; girl, Clara Bow was born in the slums of Brooklyn in a family plagued with alcoholism and insanity. She catapulted to fame after winning Motion Picture magazine&#x27;s 1921 &quot; Fame and Fortune&quot; contest. The greatest box-office draw of ..."
                },
                Price = 15.3,
                Category = Category.Biography,
                RatingCount = 922,
                Rating = 4.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/e082b0491bbfb1cbb315ba080cbd0d95.jpg" }
                }
            },
    new Book
            {
                Title = "The Triumph of Nancy Reagan",
                Author = "Karen Tumulty",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2022, 1, 1),
                    Pages = 672,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"The made-in-Hollywood marriage of Ronald and Nancy Reagan was the partnership that made him president. Nancy understood how to foster his strengths and compensate for his weaknesses-- and made herself a place in history. Tumulty shows how Nancy&#x27;s confidence developed, and reveals new details su..."
                },
                Price = 28.75,
                Category = Category.Biography,
                RatingCount = 157,
                Rating = 4.4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/1bc5aef6fda9aeecc74ac62d44888828.jpg" }
                }
            },
    new Book
            {
                Title = "Francis of Assisi - The Saint: Early Documents, vol. 1",
                Author = "Regis J. Armstrong, J. A. Wayne Hellmann, William J. Short",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1999, 1, 1),
                    Pages = 608,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "New City Press",
                    Description = @"The Saint begins this extraordinary series which brings together &quot;the writings of Saint Francis and those of the early Franciscan witnesses&quot; and it will &quot;be of estimable value to scholars, students, and lovers of Il Poverello as well...a scholarly achievement done in the service of hi..."
                },
                Price = 18.9,
                Category = Category.Biography,
                RatingCount = 1,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/accfc90229ac8ec09b8fecb71df5d7e3.jpg" }
                }
            },
    new Book
            {
                Title = "The Young Hemingway",
                Author = "Michael S. Reynolds",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1998, 1, 1),
                    Pages = 324,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "W. W. Norton &amp; Company",
                    Description = @"Revealing the early forces that helped shape Ernest Hemingway as one of America&#x27;s greatest writers--his father&#x27;s self-destructive battle with depression and his mother&#x27;s fierce independence and spiritualism--this volume of Michael Reynold&#x27;s extensive biography brings young Ernest..."
                },
                Price = 9.61,
                Category = Category.Biography,
                RatingCount = 1,
                Rating = 3f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/953f7f273cc96eb4df5537e02a77c632.jpg" }
                }
            },
    new Book
            {
                Title = "Bruce",
                Author = "Peter Ames Carlin",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2012, 1, 1),
                    Pages = 493,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"&quot; ... A stunning biography of Bruce Springsteen describing his life and work in vivid intimate detail&quot;--"
                },
                Price = 19.52,
                Category = Category.Biography,
                RatingCount = 278,
                Rating = 4.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/4be90ed9c41356ec34247e49aec714a9.jpg" }
                }
            },
    new Book
            {
                Title = "Gerald R. Ford",
                Author = "Douglas Brinkley",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2007, 1, 1),
                    Pages = 236,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Macmillan",
                    Description = @"A biography of the first president to be sworn into office as a result of his predecessor&#x27;s resignation."
                },
                Price = 12.85,
                Category = Category.Biography,
                RatingCount = 411,
                Rating = 4.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/8b8763086d1d3d22d2261f28c808bee0.jpg" }
                }
            },
    new Book
            {
                Title = "Plutarch&#x27;s Lives",
                Author = "Plutarch",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1914, 1, 1),
                    Pages = 638,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"A series of biographies of famous Greek and Roman men, arranged in tandem to illuminate their common moral virtues or failings."
                },
                Price = 21.67,
                Category = Category.Biography,
                RatingCount = 234,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/a0c320aa6db499cf85b1b6815d7389d3.jpg" }
                }
            },
    new Book
            {
                Title = "Plutarch&#x27;s Lives",
                Author = "Plutarch",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1905, 1, 1),
                    Pages = 538,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 8.28,
                Category = Category.Biography,
                RatingCount = 307,
                Rating = 4.1f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/a0c320aa6db499cf85b1b6815d7389d3.jpg" }
                }
            },
    new Book
            {
                Title = "Plutarch&#x27;s Lives Translated from the Original Greek",
                Author = "Plutarch, John Langhorne, William Langhorne",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1873, 1, 1),
                    Pages = 466,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 26.28,
                Category = Category.Biography,
                RatingCount = 407,
                Rating = 4.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/e6385f0a33ccf1a5f293f8cf00bbd793.jpg" }
                }
            },
    new Book
            {
                Title = "As You Wish",
                Author = "Cary Elwes, Joe Layden",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2014, 1, 1),
                    Pages = 272,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"From Cary Elwes, who played the iconic role of Westley in The Princess Bride, comes a first-person behind-the-scenes look at the making of the film."
                },
                Price = 23.97,
                Category = Category.Biography,
                RatingCount = 539,
                Rating = 4.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/64d4b7f1dc432e9484ef56153f631d06.jpg" }
                }
            },
    new Book
            {
                Title = "A History of Texas and Texans",
                Author = "Frank White Johnson",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1916, 1, 1),
                    Pages = 632,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 7.55,
                Category = Category.Biography,
                RatingCount = 687,
                Rating = 4.4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/bc716d2f61399cf512798d0f5e377c4a.jpg" }
                }
            },
    new Book
            {
                Title = "Aerosmith, 50th Anniversary Updated Edition",
                Author = "Richard Bienstock",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2020, 1, 1),
                    Pages = 243,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Voyageur Press",
                    Description = @"This ultimate illustrated history of Aerosmith--one of the greatest rock &#x27;n&#x27; roll bands of all time and the best-selling American hard rock band of all time--is now revised and updated to celebrate the group&#x27;s 50th anniversary as well as their multi-year farewell concert tour. This ma..."
                },
                Price = 14.43,
                Category = Category.Biography,
                RatingCount = 615,
                Rating = 4.1f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/8327fcc720c958f4840f9150b4ce1270.jpg" }
                }
            },
    new Book
            {
                Title = "Visas for Life",
                Author = "Yukiko Sugihara",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1995, 1, 1),
                    Pages = 192,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Conran Octopus",
                    Description = @"&quot;Read the first English translated memoirs by his widow, Yukiko Sugihara. Learn about the significant roles that Chiune played before, during, and after World War Two. Read about the historical forces and events that occurred during this chapter of our history and how Chiune&#x27;s decisions ma..."
                },
                Price = 11.25,
                Category = Category.Biography,
                RatingCount = 908,
                Rating = 4.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/0744c10a188fcc29258f6d6ea1844696.jpg" }
                }
            },
    new Book
            {
                Title = "Maybe You Should Talk to Someone",
                Author = "Lori Gottlieb",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2019, 1, 1),
                    Pages = 433,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Harper",
                    Description = @"&quot;From a New York Timesbest-selling writer, psychotherapist, and advice columnist, a brilliant and surprising new book that takes us behind the scenes of a therapist&#x27;s world--where her patients are in crisis (and so is she)&quot;--"
                },
                Price = 26.16,
                Category = Category.Biography,
                RatingCount = 736,
                Rating = 3.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/3e0a4beb5c4c4f6480eeefbb0f8ea2a4.jpg" }
                }
            },
    new Book
            {
                Title = "Appletons&#x27; Cyclopaedia of American Biography",
                Author = "James Grant Wilson, John Fiske",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1888, 1, 1),
                    Pages = 810,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 25.42,
                Category = Category.Biography,
                RatingCount = 678,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/331e54df1d67a1f6a162305e1503b9f9.jpg" }
                }
            },
    new Book
            {
                Title = "Plutarch&#x27;s Lives",
                Author = "Plutarch",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1804, 1, 1),
                    Pages = 448,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 22.92,
                Category = Category.Biography,
                RatingCount = 709,
                Rating = 4.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/a0c320aa6db499cf85b1b6815d7389d3.jpg" }
                }
            },
    new Book
            {
                Title = "Cleopatra",
                Author = "Joyce A. Tyldesley",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2008, 1, 1),
                    Pages = 328,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Basic Civitas Books",
                    Description = @"A biography of Cleopatra, the last ruler of the Macedonian dynasty of Ptolemies who had ruled Egypt for three centuries."
                },
                Price = 28.2,
                Category = Category.Biography,
                RatingCount = 200,
                Rating = 4.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/f8cbe5a99675fff11ed4d83fc16e2071.jpg" }
                }
            },
    new Book
            {
                Title = "Dictionary of Greek and Roman Biography and Mythology: Earinus-Nyx",
                Author = "William Smith",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1846, 1, 1),
                    Pages = 1238,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 17.48,
                Category = Category.Biography,
                RatingCount = 281,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/95bea26aeb7a4c3a2be5bf305c76c323.jpg" }
                }
            },
    new Book
            {
                Title = "Karl Marx",
                Author = "Francis Wheen",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2000, 1, 1),
                    Pages = 466,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "W. W. Norton &amp; Company",
                    Description = @"Looks at the life of the father of Communism focusing primarily on the human side of the man rather than his works."
                },
                Price = 9.84,
                Category = Category.Biography,
                RatingCount = 4,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/af66a757879551f03eb17944eff72349.jpg" }
                }
            },
    new Book
            {
                Title = "Here I Stand",
                Author = "Roland H. Bainton",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2013, 1, 1),
                    Pages = 466,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Abingdon Press",
                    Description = @"Presents the life of the German monk, whose protest against some of the doctrines of the Catholic Church led to the Protestant Reformation."
                },
                Price = 15.16,
                Category = Category.Biography,
                RatingCount = 550,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/fed85d5c6ad7bab9f8198c2c69018deb.jpg" }
                }
            },
    new Book
            {
                Title = "Plutarch&#x27;s Lives",
                Author = "Plutarch",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1841, 1, 1),
                    Pages = 486,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 24.21,
                Category = Category.Biography,
                RatingCount = 356,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/a0c320aa6db499cf85b1b6815d7389d3.jpg" }
                }
            },
    new Book
            {
                Title = "The Lives of the Noble Grecians and Romaines,",
                Author = "Plutarch",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1879, 1, 1),
                    Pages = 1214,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 21.36,
                Category = Category.Biography,
                RatingCount = 102,
                Rating = 4.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/9ef79268e6eabe82462873547d6b32e2.jpg" }
                }
            },
    new Book
            {
                Title = "Famous Men of the Middle Ages",
                Author = "John Henry Haaren, Addison B. Poland",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1904, 1, 1),
                    Pages = 284,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 8.09,
                Category = Category.Biography,
                RatingCount = 3,
                Rating = 3.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/ed2a6ac97f61e8cfd8fe39a32537c14f.jpg" }
                }
            },
    new Book
            {
                Title = "Sybil",
                Author = "Flora Rheta Schreiber",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1973, 1, 1),
                    Pages = 344,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Regnery Publishing",
                    Description = @"&quot;The true story of a woman possessed by 16 separate personalities&quot;--Jacket subtitle."
                },
                Price = 26.4,
                Category = Category.Biography,
                RatingCount = 8,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/26bd4c0a132b8d8f12d8fed1566e3874.jpg" }
                }
            },
    new Book
            {
                Title = "A Classical Dictionary of Greek and Roman Biography, Mythology and Geography",
                Author = "William Smith",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1904, 1, 1),
                    Pages = 1036,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"No description available."
                },
                Price = 16.11,
                Category = Category.Biography,
                RatingCount = 637,
                Rating = 3.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/a5a6c1ede802cc32b0aafbc6cb909064.jpg" }
                }
            },
    new Book
            {
                Title = "Society and Solitude",
                Author = "Ralph Waldo Emerson",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2007, 1, 1),
                    Pages = 554,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Harvard University Press",
                    Description = @"&quot;Society and Solitude, published in 1870, was the first collection of essays Ralph Waldo Emerson had put into press since The Conduct of Life ten years earlier. Of the twelve essays included in the volume, he had previously published seven in whole or in part: &quot;Society and Solitude,&quot; ..."
                },
                Price = 28.8,
                Category = Category.Biography,
                RatingCount = 751,
                Rating = 4.1f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/31d203a28a49e523cf7ebbaf645fbf21.jpg" }
                }
            },
    new Book
            {
                Title = "The Seven Husbands of Evelyn Hugo",
                Author = "Taylor Jenkins Reid",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2017, 1, 1),
                    Pages = 400,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"The epic adventures Evelyn creates over the course of a lifetime will leave every reader mesmerized. This wildly addictive journey of a reclusive Hollywood starlet and her tumultuous Tinseltown journey comes with unexpected twists and the most satisfying of drama."
                },
                Price = 17.07,
                Category = Category.Biography,
                RatingCount = 3,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/fb7048db4beb6c1d931a1fa880ed2dc5.jpg" }
                }
            },
    new Book
            {
                Title = "The Cancer Journals",
                Author = "Audre Lorde",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1980, 1, 1),
                    Pages = 84,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"Originally published in 1980, Audre Lorde&#x27;s The Cancer Journals offers a profoundly feminist analysis of her experience with breast cancer &amp; a modified radical mastectomy. Moving between journal entry, memoir, &amp; exposition, Lorde fuses the personal &amp; political &amp; refuses the sile..."
                },
                Price = 10.15,
                Category = Category.Biography,
                RatingCount = 933,
                Rating = 4.2f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/87a205e86ec2cae8eebc1883293e45f9.jpg" }
                }
            },
    new Book
            {
                Title = "The Discarded Image",
                Author = "C. S. Lewis",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1994, 1, 1),
                    Pages = 248,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Cambridge University Press",
                    Description = @"Hailed as &quot;the final memorial to the work of a great scholar and teacher and a wise and noble mind,&quot; this work paints a lucid picture of the medieval world view, as historical and cultural background to the literature of the Middle Ages and Renaissance."
                },
                Price = 24.51,
                Category = Category.History,
                RatingCount = 1,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/2372888c094afb258d8abd743e339124.jpg" }
                }
            },
    new Book
            {
                Title = "Alexander the Great",
                Author = "Philip Freeman",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2011, 1, 1),
                    Pages = 418,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Simon and Schuster",
                    Description = @"In the first authoritative biography of Alexander the Great written for a general audience in a generation, classicist and historian Philip Freeman tells the remarkable life of the great conqueror. The celebrated Macedonian king has been one of the most enduring figures in history. He was a general ..."
                },
                Price = 26.38,
                Category = Category.History,
                RatingCount = 228,
                Rating = 4.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/8fa3e8648939f47d1186e08fd9100b33.jpg" }
                }
            },
    new Book
            {
                Title = "The Great Depression",
                Author = "Robert S. McElvaine",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1984, 1, 1),
                    Pages = 424,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Crown",
                    Description = @"A perennial backlist performer. &quot;From the Trade Paperback edition."
                },
                Price = 17.81,
                Category = Category.History,
                RatingCount = 106,
                Rating = 4.3f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/f9fdab278c648456c55e77dcf766f01b.jpg" }
                }
            },
    new Book
            {
                Title = "Madness and Civilization",
                Author = "Michel Foucault",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1988, 1, 1),
                    Pages = 318,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Vintage",
                    Description = @"Michel Foucault examines the archeology of madness in the West from 1500 to 1800 - from the late Middle Ages, when insanity was still considered part of everyday life and fools and lunatics walked the streets freely, to the time when such people began to be considered a threat, asylums were first bu..."
                },
                Price = 29.03,
                Category = Category.History,
                RatingCount = 937,
                Rating = 4.1f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/1f8bcf89019bece3d75e1c0027904cd8.jpg" }
                }
            },
    new Book
            {
                Title = "The Soul of America",
                Author = "Jon Meacham",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2018, 1, 1),
                    Pages = 417,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Random House",
                    Description = @"#1 NEW YORK TIMES BESTSELLER • Pulitzer Prize–winning author Jon Meacham helps us understand the present moment in American politics and life by looking back at critical times in our history when hope overcame division and fear. “Gripping and inspiring, The Soul of America is Jon Meacham’s declarati..."
                },
                Price = 18.08,
                Category = Category.History,
                RatingCount = 895,
                Rating = 4.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/5b9eb9c39a8e6c3eaf758f583d8b4f8c.jpg" }
                }
            },
    new Book
            {
                Title = "The Supreme Court Reborn",
                Author = "William E. Leuchtenburg",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1996, 1, 1),
                    Pages = 363,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Oxford University Press",
                    Description = @"For almost sixty years, the results of the New Deal have been an accepted part of political life. Social Security, to take one example, is now seen as every American&#x27;s birthright. But to validate this revolutionary legislation, Franklin Roosevelt had to fight a ferocious battle against the oppo..."
                },
                Price = 12.02,
                Category = Category.History,
                RatingCount = 479,
                Rating = 3.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/3f02eecd2c6977b121630ebad358c325.jpg" }
                }
            },
    new Book
            {
                Title = "Undoing Gender",
                Author = "Judith Butler",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2004, 1, 1),
                    Pages = 292,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Psychology Press",
                    Description = @"First Published in 2004. Routledge is an imprint of Taylor &amp; Francis, an informa company."
                },
                Price = 29.22,
                Category = Category.History,
                RatingCount = 1,
                Rating = 5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/28f165779bec84de2744ef7ab7aeb30d.jpg" }
                }
            },
    new Book
            {
                Title = "The Hour of Our Death",
                Author = "Philippe Aries",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1982, 1, 1),
                    Pages = 0,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "National Geographic Books",
                    Description = @"An “absolutely magnificent” book (The New Republic)—the fruit of almost two decades of study—that traces the changes in Western attitudes toward death and dying from the earliest Christian times to the present day. A truly landmark study, The Hour of Our Death reveals a pattern of gradually developi..."
                },
                Price = 28.31,
                Category = Category.History,
                RatingCount = 833,
                Rating = 4.2f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/75b7772e52fe8639cbe65768621010a2.jpg" }
                }
            },
    new Book
            {
                Title = "The Changing Scale of American Agriculture",
                Author = "John Fraser Hart",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2003, 1, 1),
                    Pages = 320,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "University of Virginia Press",
                    Description = @"Few Americans know much about contemporary farming, which has evolved dramatically over the past few decades. In The Changing Scale of American Agriculture, the award-winning geographer and landscape historian John Fraser Hart describes the transformation of farming from the mid-twentieth century, w..."
                },
                Price = 9.87,
                Category = Category.History,
                RatingCount = 948,
                Rating = 4.2f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/ad410831a01a526a4f7c8da25cac7c53.jpg" }
                }
            },
    new Book
            {
                Title = "Strangers from a Different Shore",
                Author = "Ronald T. Takaki",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1990, 1, 1),
                    Pages = 612,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Penguin Group",
                    Description = @"In an extraordinary blend of eloquent narrative history, vivid personal recollection, and oral testimony, Ronald Takaki relates the diverse 150-year history of Asian Americans. Through richly detailed vignettes--by turns bitter, funny, and inspiring--he offers a stunning panorama of a neglected part..."
                },
                Price = 24.15,
                Category = Category.History,
                RatingCount = 158,
                Rating = 4.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/6fad751a674c123746d71906ae679bd3.jpg" }
                }
            },
    new Book
            {
                Title = "The Federalist",
                Author = "Alexander Hamilton, James Madison, John Jay",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2009, 1, 1),
                    Pages = 648,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Harvard University Press",
                    Description = @"The John Harvard Library edition of the classic American essay with an introduction by Cass Sunstein."
                },
                Price = 8.36,
                Category = Category.History,
                RatingCount = 509,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/89a563ceae0bd414a4dd49a29096a51c.jpg" }
                }
            },
    new Book
            {
                Title = "Images of Nebuchadnezzar",
                Author = "Ronald Herbert Sack",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2004, 1, 1),
                    Pages = 202,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Susquehanna University Press",
                    Description = @"Images of Nebuchadnezzar attempts to probe the diversity of cultural attitudes reflected in the characterizations of this famous king through an examination of both the original cuneiform sources as well as the accounts of chronographers written in Greek, Roman, and medieval times. Included in this ..."
                },
                Price = 10.84,
                Category = Category.History,
                RatingCount = 215,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/f61ee1bfd27e3d5a7ecaefc146db4c41.jpg" }
                }
            },
    new Book
            {
                Title = "Conservatism",
                Author = "Jerry Z. Muller",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1997, 1, 1),
                    Pages = 476,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Princeton University Press",
                    Description = @"History Professor Jerry Muller locates the origins of modern conservatism within the Enlightenment and distinguishes conservatism from orthodoxy. Reviewing important specimens of analysis from the mid18th century through our own day, Muller demonstrates that characteristic features of conservative a..."
                },
                Price = 17.36,
                Category = Category.History,
                RatingCount = 381,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/6ed17f2266a720508cd110c6086756fc.jpg" }
                }
            },
    new Book
            {
                Title = "The Witch",
                Author = "Ronald Hutton",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2017, 1, 1),
                    Pages = 385,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Yale University Press",
                    Description = @"This book sets the notorious European witch trials in the widest and deepest possible perspective and traces the major historiographical developments of witchcraft"
                },
                Price = 16.6,
                Category = Category.History,
                RatingCount = 616,
                Rating = 3.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/3ecb1133e799b082ef2ce14eafb8cdc2.jpg" }
                }
            },
    new Book
            {
                Title = "The Gates of Europe",
                Author = "Serhii Plokhy",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2015, 1, 1),
                    Pages = 433,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Basic Books",
                    Description = @"Ukraine is currently embroiled in a tense battle with Russia to preserve its economic and political independence. But today&#x27;s conflict is only the latest in a long history of battles over Ukraine&#x27;s existence as a sovereign nation. As award-winning historian Serhii Plokhy argues in The Gate..."
                },
                Price = 18.39,
                Category = Category.History,
                RatingCount = 408,
                Rating = 4.3f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/c037839352ba0e701d520b49bdf736f5.jpg" }
                }
            },
    new Book
            {
                Title = "The American Discovery of Europe",
                Author = "Jack D. Forbes",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2010, 1, 1),
                    Pages = 270,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "University of Illinois Press",
                    Description = @"The American Discovery of Europe investigates the voyages of America&#x27;s Native peoples to the European continent before Columbus&#x27;s 1492 arrival in the &quot;New World.&quot; The product of over twenty years of exhaustive research in libraries throughout Europe and the United States, the boo..."
                },
                Price = 28.96,
                Category = Category.History,
                RatingCount = 275,
                Rating = 4.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/afe3ae70c6a5e626c0b615dcab48b66c.jpg" }
                }
            },
    new Book
            {
                Title = "Aftermath",
                Author = "Harald Jähner",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2022, 1, 1),
                    Pages = 417,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Knopf",
                    Description = @"How does a nation recover from fascism and turn toward a free society once more? This internationally acclaimed revelatory history—&quot;filled with first-person accounts from articles and diaries&quot; (The New York Times)—of the transformational decade that followed World War II illustrates how Ge..."
                },
                Price = 6.78,
                Category = Category.History,
                RatingCount = 78,
                Rating = 4.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/c4b01705fe2a1eccec52d7eb50d8df07.jpg" }
                }
            },
    new Book
            {
                Title = "The European Rescue of the Nation-state",
                Author = "Alan S. Milward",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2000, 1, 1),
                    Pages = 494,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Psychology Press",
                    Description = @"Newly revised and updated, this second edition is the classic economic and political account of the origins of the European Community book offers a challenging interpretation of the history of the western European state and European integration."
                },
                Price = 23.06,
                Category = Category.History,
                RatingCount = 136,
                Rating = 4.2f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/046c54fa0b4507a0a86079c0f899e7ff.jpg" }
                }
            },
    new Book
            {
                Title = "Imperial Twilight",
                Author = "Stephen R. Platt",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2018, 1, 1),
                    Pages = 610,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Vintage",
                    Description = @"As China reclaims its position as a world power, Imperial Twilight looks back to tell the story of the country’s last age of ascendance and how it came to an end in the nineteenth-century Opium War. As one of the most potent turning points in the country’s modern history, the Opium War has since com..."
                },
                Price = 8.71,
                Category = Category.History,
                RatingCount = 396,
                Rating = 4.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/60161c427eb9d008b7dbbd592258951b.jpg" }
                }
            },
    new Book
            {
                Title = "An Introduction to Book History",
                Author = "David Finkelstein, Alistair McCleery",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2013, 1, 1),
                    Pages = 178,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Routledge",
                    Description = @"This second edition of An Introduction to Book History provides a comprehensive critical introduction to the development of the book and print culture. Each fully revised and updated chapter contains new material and covers recent developments in the field, including: The Postcolonial Book Censorshi..."
                },
                Price = 25.9,
                Category = Category.History,
                RatingCount = 550,
                Rating = 3.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/2366031a9b8984adf9c864b17b48ebfc.jpg" }
                }
            },
    new Book
            {
                Title = "Who Killed Homer?",
                Author = "Victor Davis Hanson, John Heath",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2001, 1, 1),
                    Pages = 362,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Encounter Books",
                    Description = @"With advice and informative readings of the great Greek texts, this title shows how we might save classics and the Greeks. It is suitable for those who agree that knowledge of classics acquaints us with the beauty and perils of our own culture."
                },
                Price = 6.81,
                Category = Category.History,
                RatingCount = 572,
                Rating = 3.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/82ccdcdefa8ce7b39cef65f3153182df.jpg" }
                }
            },
    new Book
            {
                Title = "Bobby and J. Edgar Revised Edition",
                Author = "Burton Hersh",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2008, 1, 1),
                    Pages = 658,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Unknown",
                    Description = @"The history of one of the most admired (Bobby Kennedy) and one of the most reviled (J. Edgar Hoover) are entwined with that of Joseph Kennedy"
                },
                Price = 20.33,
                Category = Category.History,
                RatingCount = 96,
                Rating = 4.3f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/02fb3b4531400dc95137a0f11ed9ccbf.jpg" }
                }
            },
    new Book
            {
                Title = "Sunset Park",
                Author = "Paul Auster",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2010, 1, 1),
                    Pages = 318,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Faber &amp; Faber",
                    Description = @"Auster&#x27;s novel of love and forgiveness from the author of contemporary classic The New York Trilogy: &#x27;a literary voice for the ages&#x27; ( Guardian) S unset Park is set in the sprawling flatlands of Florida, where twenty-eight-year-old Miles is photographing the last lingering traces of f..."
                },
                Price = 18.59,
                Category = Category.History,
                RatingCount = 1,
                Rating = 4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/764e4a58e3c2b8102fd32c29b7eebebe.jpg" }
                }
            },
    new Book
            {
                Title = "Reflections On Russia",
                Author = "Dmitrii S Likhachev",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2019, 1, 1),
                    Pages = 243,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Routledge",
                    Description = @"Among the most respected public figures in Russia today, Dmitrii Sergeevich Likhachev has profoundly influenced generations of Soviet historians, literary scholars, philosophers, and other intellectual and cultural leaders. This is the only available English translation of his Zametki o russkom, a c..."
                },
                Price = 7.72,
                Category = Category.History,
                RatingCount = 987,
                Rating = 3.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/5e85f854bd4cadb99acd3204d4122f73.jpg" }
                }
            },
    new Book
            {
                Title = "Fanshen",
                Author = "William Hinton, Fred Magdoff",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2008, 1, 1),
                    Pages = 669,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "NYU Press",
                    Description = @"More than forty years after its initial publication, William Hinton’s Fanshen continues to be the essential volume for those fascinated with China’s revolutionary process of rural reform and social change. A pioneering work, Fanshan is a marvelous and revealing look into life in the Chinese countrys..."
                },
                Price = 14.08,
                Category = Category.History,
                RatingCount = 405,
                Rating = 4.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/915feb24b41228903ff369f70a4132a9.jpg" }
                }
            },
    new Book
            {
                Title = "From POW to Blue Angel",
                Author = "James Lowell Armstrong",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2006, 1, 1),
                    Pages = 332,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "University of Oklahoma Press",
                    Description = @"As a young naval aviator, Dusty Rhodes was shot down by the Japanese on his first combat mission in World War II. Toughing out the rest of the war in POW camps, he wondered if he would ever fly again. But Rhodes was destined to take flying to new heights. As only the third fighter pilot to become le..."
                },
                Price = 13.65,
                Category = Category.History,
                RatingCount = 648,
                Rating = 4.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/feee41d393366b4aef630fc52510028d.jpg" }
                }
            },
    new Book
            {
                Title = "Beyond War",
                Author = "Douglas P. Fry",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2007, 1, 1),
                    Pages = 353,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Oxford University Press",
                    Description = @"The classic opening scene of 2001, A Space Odyssey shows an ape-man wreaking havoc with humanity&#x27;s first invention--a bone used as a weapon to kill a rival. It&#x27;s an image that fits well with popular notions of our species as inherently violent, with the idea that humans are--and always hav..."
                },
                Price = 26.39,
                Category = Category.History,
                RatingCount = 562,
                Rating = 4.4f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/cfc1ee797a1fac45c764697f97a0a6cc.jpg" }
                }
            },
    new Book
            {
                Title = "God and Reason in the Middle Ages",
                Author = "Edward Grant",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2001, 1, 1),
                    Pages = 412,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Cambridge University Press",
                    Description = @"Between 1100 and 1600, the emphasis on reason in the learning and intellectual life of Western Europe became more pervasive and widespread than ever before in the history of human civilization. Of crucial significance was the invention of the university around 1200, within which reason was instituti..."
                },
                Price = 26.4,
                Category = Category.History,
                RatingCount = 2,
                Rating = 3f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/82b49c0675cfbedb4224898926a55046.jpg" }
                }
            },
    new Book
            {
                Title = "Women and Confucian Cultures in Premodern China, Korea, and Japan",
                Author = "Dorothy Ko, JaHyun Kim Haboush, Joan Piggott",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2003, 1, 1),
                    Pages = 353,
                    Edition = "1st Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Univ of California Press",
                    Description = @"Representing an unprecedented collaboration among international scholars from Asia, Europe, and the United States, this volume rewrites the history of East Asia by rethinking the contentious relationship between Confucianism and women. The authors discuss the absence of women in the Confucian canoni..."
                },
                Price = 24.99,
                Category = Category.History,
                RatingCount = 590,
                Rating = 3.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/ba94222cfed4a6f27921032303080bda.jpg" }
                }
            },
    new Book
            {
                Title = "Death of a Generation",
                Author = "Howard Jones",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2003, 1, 1),
                    Pages = 593,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Oxford University Press",
                    Description = @"When John F. Kennedy was shot, millions were left to wonder how America, and the world, would have been different had he lived to fulfill the enormous promise of his presidency. For many historians and political observers, what Kennedy would and would not have done in Vietnam has been a source of en..."
                },
                Price = 9.95,
                Category = Category.History,
                RatingCount = 300,
                Rating = 4.1f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/1b4e919d0f963064814d9b65af44ba01.jpg" }
                }
            },
    new Book
            {
                Title = "The Measure of a Man",
                Author = "Dr. Martin Luther King Jr.",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2017, 1, 1),
                    Pages = 28,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Pickle Partners Publishing",
                    Description = @"First published in 1959, this pair of meditations by the revered civil-rights leader Martin Luther King, Jr. contains the theological roots of his political and social philosophy of nonviolent activism. Eloquent and passionate, reasoned and sensitive. “AT THE first National Conference on Christian E..."
                },
                Price = 28.41,
                Category = Category.History,
                RatingCount = 287,
                Rating = 5.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/3dccf7f5492eaab4be20cc22d60572e1.jpg" }
                }
            },
    new Book
            {
                Title = "The Book of Mormon",
                Author = "Joseph Smith",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2018, 1, 1),
                    Pages = 442,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Createspace Independent Publishing Platform",
                    Description = @"The legendary text from the great Joseph Smith, enjoy."
                },
                Price = 29.22,
                Category = Category.History,
                RatingCount = 1,
                Rating = 1f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/6163f4fe4bc3db229e05a1fc25afce13.jpg" }
                }
            },
    new Book
            {
                Title = "Thomas Jefferson: The Art of Power",
                Author = "Jon Meacham",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2012, 1, 1),
                    Pages = 0,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "National Geographic Books",
                    Description = @"NAMED ONE OF THE BEST BOOKS OF THE YEAR BY The New York Times Book Review • The Washington Post • Entertainment Weekly • The Seattle Times • St. Louis Post-Dispatch • Bloomberg Businessweek In this magnificent biography, the Pulitzer Prize–winning author of American Lion and Franklin and Winston bri..."
                },
                Price = 16.76,
                Category = Category.History,
                RatingCount = 135,
                Rating = 4.8f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/c41bb14a4d0707df1677e1789adfb103.jpg" }
                }
            },
    new Book
            {
                Title = "The Invention of Pornography, 1500–1800",
                Author = "Lynn Hunt",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1993, 1, 1),
                    Pages = 413,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "MIT Press",
                    Description = @"A collection of ten essays tracing the history and various uses of pornography in early modern Europe.In America today the intense and controversial debate over the censorship of pornography continues to call into question the values of a modern, democratic culture. This ground-breaking collection o..."
                },
                Price = 6.46,
                Category = Category.History,
                RatingCount = 680,
                Rating = 3.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/4de662474d7ad8ce3bf7781c39dcf7c6.jpg" }
                }
            },
    new Book
            {
                Title = "Benjamin Franklin and the American Revolution",
                Author = "Jonathan R. Dull",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2010, 1, 1),
                    Pages = 184,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "U of Nebraska Press",
                    Description = @"The inventor, the ladies? man, the affable diplomat, and the purveyor of pithy homespun wisdom: we all know the charming, resourceful Benjamin Franklin. What is less appreciated is the importance of Franklin?s part in the American Revolution:øexcept for Washington he was its most irreplaceable leade..."
                },
                Price = 13.89,
                Category = Category.History,
                RatingCount = 656,
                Rating = 5.0f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/ad0dfed9507dac4f4fe8b954a4647f5b.jpg" }
                }
            },
    new Book
            {
                Title = "Ghost Ship of Diamond Shoals",
                Author = "Bland Simpson",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2002, 1, 1),
                    Pages = 264,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "UNC Press Books",
                    Description = @"The extraordinary wreck of a majestic ship, a mysteriously missing crew, a message in a bottle, the lost captain&#x27;s determined daughter - these are all elements of a great sea yarn, and one that happens to be true. Bland Simpson weaves them together in this nonfiction novel, his reconstruction o..."
                },
                Price = 20.52,
                Category = Category.History,
                RatingCount = 504,
                Rating = 3.7f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/e3c7045dc17b148f132f9bf71bf9b280.jpg" }
                }
            },
    new Book
            {
                Title = "Uncle Tom&#x27;s Cabin, Or, Life Among the Lowly",
                Author = "Harriet Beecher Stowe",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2018, 1, 1),
                    Pages = 338,
                    Edition = "2nd Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Franklin Classics Trade Press",
                    Description = @"This work has been selected by scholars as being culturally important and is part of the knowledge base of civilization as we know it. This work is in the public domain in the United States of America, and possibly other nations. Within the United States, you may freely copy and distribute this work..."
                },
                Price = 24.39,
                Category = Category.History,
                RatingCount = 526,
                Rating = 4.9f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/153b79d44334eb917fab42a2b7789632.jpg" }
                }
            },
    new Book
            {
                Title = "Constantinople: Capital of Byzantium",
                Author = "Jonathan Harris",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2009, 1, 1),
                    Pages = 308,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "A&amp;C Black",
                    Description = @"This book examines the intriguing interaction between the spiritual and the political whilst reconstructs the awe-inspiring city in its heyday of 1200."
                },
                Price = 24.44,
                Category = Category.History,
                RatingCount = 451,
                Rating = 4.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/5728d830bfc97b4d62047ab1330039c8.jpg" }
                }
            },
    new Book
            {
                Title = "The Spirit of the Sixties",
                Author = "James J. Farrell",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(1997, 1, 1),
                    Pages = 370,
                    Edition = "Deluxe Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "Psychology Press",
                    Description = @"First Published in 1997. Routledge is an imprint of Taylor &amp; Francis, an informa company."
                },
                Price = 26.77,
                Category = Category.History,
                RatingCount = 988,
                Rating = 4.6f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/55da86e3a0e9baf364bc45e251c82839.jpg" }
                }
            },
    new Book
            {
                Title = "METEOROLOGY",
                Author = "Aristotle",
                BookInfo = new BookInfo
                {
                    PublicationYear = new DateTime(2017, 1, 1),
                    Pages = 166,
                    Edition = "Special Edition",
                    AvailableTypes = new List<BookInfoAvailableType>
                    {
                        new BookInfoAvailableType() { BookType = BookType.eBook },
                        new BookInfoAvailableType() { BookType = BookType.Hardcover },
                        new BookInfoAvailableType() { BookType = BookType.Paperback },
                    },
                    Publisher = "右灰文化傳播有限公司可提供下載列印",
                    Description = @"�WE have already discussed the first causes of nature, and all natural motion, also the stars ordered in the motion of the heavens, and the physical element-enumerating and specifying them and showing how they change into one another-and becoming and perishing in general. There remains for considera..."
                },
                Price = 8.31,
                Category = Category.History,
                RatingCount = 949,
                Rating = 3.5f,
                BookPath = "Data/Books/test.pdf",
                BookImages = new List<BookImage>
                {
                    new BookImage { Url = "Data/BookImage/30636f66d5962ce7d04f42ba3d9d3294.jpg" }
                }
            },
                new Book
                {
                    Title = "The Death of Ivan Ilyich", Author = "Leo Tolstoy",
                    BookInfo = new BookInfo
                    {
                        PublicationYear = new DateTime(2008, 5, 27),
                        Pages = 317, Edition = "1st Edition",
                        AvailableTypes = new List<BookInfoAvailableType>
                        {
                            new BookInfoAvailableType() { BookType = BookType.eBook },
                            new BookInfoAvailableType() { BookType = BookType.Hardcover },
                            new BookInfoAvailableType() { BookType = BookType.Paperback },
                        },
                        Publisher = "Penguin Classics",
                        Description = @"Here are some of Tolstoy's extraordinary short stories, from ""The Death of Ivan Ilyich."" in a masterly new translation, to ""The Raid,"" ""The Wood-felling,"" ""Three Deaths,"" ""Polikushka,"" ""After the Ball,"" and ""The Forged Coupon,"" all gripping and eloquent lessons on two of Tolstoy's most persistent themes: life and death. More experimental than his novels, Tolstoy's stories are essential reading for anyone interested in his development as one of the major writers and thinkers of his time. 

For more than seventy years, Penguin has been the leading publisher of classic literature in the English-speaking world. With more than 1,700 titles, Penguin Classics represents a global bookshelf of the best works throughout history and across genres and disciplines. Readers trust the series to provide authoritative texts enhanced by introductions and notes by distinguished scholars and contemporary authors, as well as up-to-date translations by award-winning translators.",
                        
                    },
                    Price = 12.00, Category = Category.Classic, RatingCount = 4123,
                    Rating = 4.7f, BookPath = "Data/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "Data/BookImage/ivanilyich.jpg"
                        }
                    }
                },
                new Book
                {
                    Title = "To Kill a Mockingbird", Author = "Harper Lee",
                    BookInfo = new BookInfo
                    {
                        PublicationYear = new DateTime(1988, 10, 11),
                        Pages = 384, Edition = "1st Edition",
                        AvailableTypes = new List<BookInfoAvailableType>
                        {
                            new BookInfoAvailableType() { BookType = BookType.eBook },
                            new BookInfoAvailableType() { BookType = BookType.Hardcover },
                            new BookInfoAvailableType() { BookType = BookType.Paperback },
                        },
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, RatingCount = 1234,
                    Rating = 4.0f, BookPath = "Data/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "Data/BookImage/tokillamockingbird.jpg"
                        }
                    }
                },
            };
            
            
            books.ForEach(b => context.Inventory.Add(
                new Inventory()
                {
                    Book = b,
                    AmountInStock = 3,
                }
                )); 

            admins.ForEach(a => context.Admin.Add(a));
            users.ForEach(u => context.User.Add(u));
            books.ForEach(b => context.Book.Add(b));
            
            context.SaveChanges();
        } 
    }
}