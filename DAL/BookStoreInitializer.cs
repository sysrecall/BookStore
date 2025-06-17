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
                    Title = "The Death of Ivan Ilyich", Author = "Leo Tolstoy",
                    BookInfo = new BookInfo
                    {
                        PublicationYear = new DateTime(2008, 5, 27),
                        Pages = 317, Edition = "1st Edition",
                        BookType = BookType.eBook,
                        Publisher = "Penguin Classics",
                        Description = @"Here are some of Tolstoy's extraordinary short stories, from ""The Death of Ivan Ilyich."" in a masterly new translation, to ""The Raid,"" ""The Wood-felling,"" ""Three Deaths,"" ""Polikushka,"" ""After the Ball,"" and ""The Forged Coupon,"" all gripping and eloquent lessons on two of Tolstoy's most persistent themes: life and death. More experimental than his novels, Tolstoy's stories are essential reading for anyone interested in his development as one of the major writers and thinkers of his time. 

For more than seventy years, Penguin has been the leading publisher of classic literature in the English-speaking world. With more than 1,700 titles, Penguin Classics represents a global bookshelf of the best works throughout history and across genres and disciplines. Readers trust the series to provide authoritative texts enhanced by introductions and notes by distinguished scholars and contemporary authors, as well as up-to-date translations by award-winning translators.",
                        
                    },
                    Price = 12.00, Category = Category.Classic, SoldInLifetime = 4123,
                    Rating = 4.7f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/61yeM7H40SL._SY466_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, RatingCount = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
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
                        BookType = BookType.eBook,
                        Publisher = "Grand Central Publishing",
                        Description = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.

Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature."
                    },
                    Price = 21.25, Category = Category.Classic, RatingCount = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
                        }
                    }
                }
            };

            admins.ForEach(a => context.Admin.Add(a));
            users.ForEach(u => context.User.Add(u));
            books.ForEach(b => context.Book.Add(b));
            
            context.SaveChanges();
        } 
    }
}