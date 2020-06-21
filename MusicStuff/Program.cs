using System;

namespace MusicStuff
{
    class Program
    {

        class Music
        {
            private bool doYouListenToMusic;
            private double yearsOfPlayingTheInstrument;

            /////////////////////////////////////////////////////////////
            public bool DoYouListenToMusic
            {
                get { return doYouListenToMusic; }
                set
                {
                    if (doYouListenToMusic == true) doYouListenToMusic = value;
                }
            }

            public double YearsOfPlayingTheInstrument
            {
                get { return yearsOfPlayingTheInstrument; }
                set
                {
                    if (yearsOfPlayingTheInstrument > 0) yearsOfPlayingTheInstrument = value;
                }
            }

            /////////////////////////////////////////////////////////////

            public Music() { }

            public Music(bool DoYouListenToMusic) 
            {
                doYouListenToMusic = DoYouListenToMusic;
            }
            
            public Music(double YearsOfPlayingTheInstrument) 
            {
                yearsOfPlayingTheInstrument = YearsOfPlayingTheInstrument;
            }
            
            public Music(bool DoYouListenToMusic, double YearsOfPlayingTheInstrument) 
            {
                doYouListenToMusic = DoYouListenToMusic;
                yearsOfPlayingTheInstrument = YearsOfPlayingTheInstrument;
            }

            /////////////////////////////////////////////////////////////

            public void WriteYourFavoriteMusicGenres(string MusicGenres)
            {
                Console.WriteLine("Ваши любимые музыкальные жанры: " + MusicGenres + "\n");
            }

            public void ToCreateSong(string Genre)
            {
                Console.WriteLine("Вы создали свою песню в жанре " + Genre + "\n");
            }

            public void MusicIsPlaying()
            {
                Console.WriteLine("Вы запустили музыкальный проигрыватель\n");
            }
        }

        class Guitar : Music
        {
            private double cost;
            private string material;

            public double Cost
            {
                get { return cost; }
                set
                {
                    if (cost > 0) cost = value;
                }
            }

            public string Material
            {
                get { return material; }
                set
                {
                    if (material != "") material = value;
                }
            }

            /////////////////////////////////////////////////////////////
            
            public Guitar() { }

            public Guitar(double Cost)
            {
                cost = Cost;
            }

            public Guitar(string Material)
            {
                material = Material;
            }
            
            public Guitar(double Cost, string Material)
            {
                cost = Cost;
                material = Material;
            }

            /////////////////////////////////////////////////////////////

            public void ToPlayTheGuitar()
            {
                Console.WriteLine("Вы играете на гитаре, все собираются вокруг вас и молча замирают, " +
                                "кажется, будто этот вечер был создан только для тех немногих, что окружили" +
                                " музыканта.\n");
            }

            public void FixTheGuitar()
            {
                Console.WriteLine("Гриф гитары надломился и вы пытаетесь его починить, как ни странно" +
                    ", но у вас это получается и вы продолжаете играть дальше\n");
            }

            public void BuyAGuitar()
            {
                Console.WriteLine("Вы пришли в магазин и купили гитару\n");
            }
        }

        class MusicStudent : Music
        {
            private bool talent;
            private string skillLevel;

            public bool Talent
            {
                get { return talent; }
                set
                {
                    if (talent == true) talent = value;
                }
            }

            public string SkillLevel
            {
                get { return skillLevel; }
                set
                {
                    if (skillLevel != "") skillLevel = value;
                }
            }

            /////////////////////////////////////////////////////////////

            public MusicStudent() { }

            public MusicStudent(bool Talent)
            {
                talent = Talent;
            }
            
            public MusicStudent(string SkillLevel)
            {
                skillLevel = SkillLevel;
            }
            
            public MusicStudent(bool Talent, string SkillLevel)
            {
                talent = Talent;
                skillLevel = SkillLevel;
            }

            /////////////////////////////////////////////////////////////

            public void ToWalkToMusicSchool(bool question)
            {
                if (question == true) Console.WriteLine("Вы решили пойти в музыкальную школу\n");
                if (question == false) Console.WriteLine("Вы решили, что сегодня лучше сделать себе выходной и" +
                                                         " не пошли в музыкальную школу\n");
            }

            public void ToTrainThePiano()
            {
                Console.WriteLine("Вы решили немного попрактиковаться в игре на пианино\n");
            }

            public void ConductAnOrchestra()
            {
                Console.WriteLine("Вы дирижируете оркестром\n");
            }
        }

        static void Main(string[] args)
        {
            Music music = new Music(true, 3);
            Guitar guitar = new Guitar(15000, "Красное дерево");
            MusicStudent musicStudent = new MusicStudent(true, "Опытный блюзмен");

            Console.WriteLine("Слушаете ли вы музыку? - " + music.DoYouListenToMusic + "\nСколько вы играете" +
                " на вашем инструменте? - " + music.YearsOfPlayingTheInstrument + " года\n");

            Console.WriteLine("Сколько стоит ваша гитара? - " + guitar.Cost + "\nИз какого она материала? - " +
                guitar.Material + "\n");

            Console.WriteLine("Талантливый ли вы музыкант? - " + musicStudent.Talent + "\n" +
                "Каким образом вы бы характеризовали себя, как музыканта? - " + musicStudent.SkillLevel + "\n");

            Console.WriteLine("(((((((((( Методы )))))))))\n----------------------------------------");
            music.WriteYourFavoriteMusicGenres("Rock, Indie, Pop");
            music.ToCreateSong("R&B");
            music.MusicIsPlaying();

            guitar.ToPlayTheGuitar();
            guitar.FixTheGuitar();
            guitar.BuyAGuitar();

            musicStudent.ToWalkToMusicSchool(false);
            musicStudent.ToTrainThePiano();
            musicStudent.ConductAnOrchestra();
        }
    }
}
