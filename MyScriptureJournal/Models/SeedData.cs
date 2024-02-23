using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;

namespace MyScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                if (context == null || context.Scripture == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        EntryDate = DateTime.Parse("2024-2-18"),
                        StandardWork = "Old Testament",
                        Book = "Exodus",
                        Chapter = 19,
                        StartVerse = 5,
                        EndVerse = 6,
                        Impression = "Mastery; tresure for keeping covenants",
                        VerseText = "Now therefore, if ye will obey my voice indeed, and keep my covenant, then ye shall be a peculiar treasure unto me above all people: for all the earth is mine: And ye shall be unto me a kingdom of priests, and an holy nation.  These are the words which thou shalt speak unto the children of Israel.",
                    },

                    new Scripture
                    {
                        EntryDate = DateTime.Parse("2024-2-19"),
                        StandardWork = "New Testament",
                        Book = "John",
                        Chapter = 14,
                        StartVerse = 6,
                        EndVerse = null,
                        Impression = "We all need Christ",
                        VerseText = "Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me.",
                    },

                    new Scripture
                    {
                        EntryDate = DateTime.Parse("2024-2-20"),
                        StandardWork = "Book of Mormon",
                        Book = "1 Nephi",
                        Chapter = 3,
                        StartVerse = 7,
                        EndVerse = null,
                        Impression = "the Lord gives us strength",
                        VerseText = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
                    },

                    new Scripture
                    {
                        EntryDate = DateTime.Parse("2024-2-21"),
                        StandardWork = "D&C",
                        Book = "D&C",
                        Chapter = 10,
                        StartVerse = 5,
                        EndVerse = null ,
                        Impression = "Prayer helps us conquer",
                        VerseText = "Pray always, that you may come off conqueror; yea, that you may conquer Satan, and that you may escape the hands of the servants of Satan that do uphold his work.",
                    },

                    new Scripture
                    {
                        EntryDate = DateTime.Parse("2024-2-22"),
                        StandardWork = "Book of Mormon",
                        Book = "2 Nephi",
                        Chapter = 4,
                        StartVerse = 28,
                        EndVerse = null,
                        Impression = "Shake off discouragement",
                        VerseText = "Awake my soul! No longer droop in sin. Rejoice, O my heart, and give place no more for the enemy of my soul."
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
