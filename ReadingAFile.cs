using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using System.Timers;
namespace PIWorks
{
    public class myComparer : IComparer<KeyValuePair<string,int>>
    {
        public bool Equals(KeyValuePair<string,int> x, KeyValuePair<string,int> y)
        {
            if(x.Key == y.Key)
            return true;
            
            return false;
        }
	
        public int GetHashCode(Object obj)
        {
            return obj.GetHashCode();
        }

        public int Compare(KeyValuePair<string, int> x, KeyValuePair<string, int> y)
        {
            var keyComparison = string.Compare(x.Key, y.Key, StringComparison.Ordinal);
            if (keyComparison != 0) return keyComparison;
            
            return 0;
        }
    }
    
    public class myComparer2 : IComparer<int>
    {
        public bool Equals(int x, int y)
        {
            if(x == y)
                return true;
            
            return false;
        }
	
        public int GetHashCode(Object obj)
        {
            return obj.GetHashCode();
        }

        public int Compare(int x, int y)
        {
            if (x < y)
                return 1;
            if (x > y)
                return -1;
            else
            {
                return 0;
            }
  //          if (keyComparison != 0) return keyComparison;
            
//            return 0;
        }
    }
    public class ReadingAFile
    {
        public int topla(int[] dimension,int level)
        {
            int length = dimension.Length;
            int sum = 0;
            if (level > length)
                return -1;
            for (int i = 0; i < level; i++)
                sum += dimension[i];

            return sum;
        }

        public static int myMathPower(int a)
        {
            int powerOf = 2;
            while (powerOf < a) powerOf *= 2;
            return powerOf;
        }
        public static string getMyFileName()
        {
            Console.WriteLine("Please enter the path with the name of file");
            String userFile = Console.ReadLine();
            String myFile;
            
            if (userFile.Length != 0)
                myFile = userFile;
            else
            {
                myFile = new String("C:\\Users\\metet\\Downloads\\exhibitA-input\\exhibitA-input.csv");
            }
            //string myFileDirectory = myFile.Substring(0,myFile.LastIndexOf('\\'));
            //string myFiles = @myFileDirectory;
            //string zipFileDirectory = @myFileDirectory+"\\exhibitA-input.zip";

            //System.IO.Compression.ZipFile.ExtractToDirectory(zipFileDirectory, myFiles);

            return myFile;
        }
        public static void readMyFile()
        {
            System.Timers.Timer timer = new System.Timers.Timer(TimeSpan.FromMinutes(0.5).TotalMilliseconds);
            timer.AutoReset = true;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(WaitingForSomeTime);
            timer.Start();
            String myFile;
            String[] lines;
            bool flag = true;
            
            try
            {
                myFile = getMyFileName();
            }
            catch (Exception e)
            {
                Console.WriteLine("There is an error");
                return; 
            }
            lines = File.ReadAllLines(myFile);
            int sayac = -1; 
            int limits = (myMathPower((int)(Math.Sqrt (lines.Length) *10) ) <lines.Length)?(int) myMathPower((int)(Math.Sqrt (lines.Length) *10)):myMathPower((int)(Math.Sqrt (lines.Length) ));
            const int partyCountPlays = 4097;
            const int partyCountSongs = 1025;
            const int partyCountClients = 1025;
            const int partyCountTimes = 4097;
            const int partyCountDateTimes = 4097;
            const int partyCountDats = 4097;
            int dynamicSidePlays = 0;
            int dynamicSideSongs = 0;
            int dynamicSideClients = 0;
            int dynamicSideTimes = 0;
            int dynamicSideDateTimes = 0;
            int dynamicSideDats = 0;
            int tempIndex = 0;
            int length = lines.Length;
            String separator = "\t";
            String separator2 = " ";
            HashSet<string>[][] plays = new HashSet<string>[1][];
//            HashSet<string>[] clients = new HashSet<string>[1];
            HashSet<string>[][] clients = new HashSet<string>[1][];
            HashSet<string>[][] songs = new HashSet<string>[1][];
//            HashSet<string>[] songs = new HashSet<string>[2];
            HashSet<string>[] times = new HashSet<string>[partyCountTimes];
            HashSet<string> dates = new HashSet<string>();
            HashSet<string>[] datetimes = new HashSet<string>[partyCountDateTimes];
            HashSet<DateTime>[] dats = new HashSet<DateTime>[partyCountDats];

            HashSet<DateTime> datesDT = new HashSet<DateTime>();
            HashSet<DateTime> timesDT = new HashSet<DateTime>();
            HashSet<DateTime> years = new HashSet<DateTime>();
            HashSet<DateTime> months = new HashSet<DateTime>();
            HashSet<DateTime> days = new HashSet<DateTime>();
            HashSet<DateTime> hours = new HashSet<DateTime>();
            HashSet<DateTime> minutes = new HashSet<DateTime>();
            HashSet<DateTime> seconds = new HashSet<DateTime>();
            
            for (int i = 0; i < partyCountTimes; i++)
                times[i] = new HashSet<string>();
            for (int i = 0; i < partyCountDateTimes; i++)
                datetimes[i] = new HashSet<string>();
            for (int i = 0; i < partyCountDats; i++)
                dats[i] = new HashSet<DateTime>();

            String playId;
            String songId;
            String clientId;
            String timeId;
            String dateId;
            String datetimeId;
            DateTime datId;
            DateTime datesDTId;
            DateTime timesDTId;
            DateTime yearId;
            DateTime monthId;
            DateTime dayId;
            DateTime hourId;
            DateTime minuteId;
            DateTime secondId;
            
            List<int>[][] playNos = new List<int>[1][];
            ArrayList[][] clientNos2 = new ArrayList[1][];
            List<int>[][] songNos = new List<int>[1][];
//            List<int> [] songNos = new List<int>[2];
            List<int>[][] clientNos = new List<int>[1][];
//            List<int> [] clientNos = new List<int>[2];
            List<int>[] timeNos = new List<int>[partyCountTimes];
            List<int> dateNos = new List<int>();
            List<int>[] datetimeNos = new List<int>[partyCountDateTimes];
            List<int>[] datNos = new List<int>[partyCountDats];
            List<int> datesDTNos = new List<int>();
            List<int> timesDTNos = new List<int>();
            List<int> yearNos = new List<int>();
            List<int> monthNos = new List<int>();
            List<int> dayNos = new List<int>();
            List<int> hourNos = new List<int>();
            List<int> minuteNos = new List<int>();
            List<int> secondNos = new List<int>();

            //          for(int i = 0; i<partyCountPlays;i++)
            //              playNos[i]= new List<int>();
/*            for (int i = 0; i < partyCountSongs; i++)
                songNos[i] = new List<int>();
            for (int i = 0; i < partyCountClients; i++)
                clientNos[i] = new List<int>();*/
            for (int i = 0; i < partyCountTimes; i++)
                timeNos[i] = new List<int>();
            for (int i = 0; i < partyCountDateTimes; i++)
                datetimeNos[i] = new List<int>();
            for (int i = 0; i < partyCountDats; i++)
                datNos[i] = new List<int>();

            String lineTemp = lines[0];
            String[] tempString = lineTemp.Split(separator);
            String[] tempString2 = tempString[1].Split(separator2);
            playId = tempString[0];
            songId = tempString[1];
            clientId = tempString[2];
            timeId = tempString[3];
            DateTime start = DateTime.Now;
            DateTime previous = DateTime.Now;
            double average = 0;
            DateTime end;
            if (sayac >= (length - 1))
                return;
            sayac += 2;
            double lapAvg = 0;
            DateTime lapSt;
            double lapSt2 = 0;
            plays[0] = new HashSet<string>[(length / partyCountPlays + 1)];
            plays[0][dynamicSidePlays] = new HashSet<string>();
            playNos[0] = new List<int>[(length / partyCountPlays + 1)];
            ;
            playNos[0][dynamicSidePlays] = new List<int>();
            sayac = 1;
            dynamicSideSongs = 0;
            dynamicSideClients = 0;
            start = DateTime.Now;
            bool flag2 = false;
            clients[0] = new HashSet<string>[1];
            clients[0][dynamicSideClients] = new HashSet<string>();
            clientNos[0] = new List<int>[1];
            ;
            clientNos[0][dynamicSideClients] = new List<int>();

            clientNos2[0] = new ArrayList[1];
            clientNos2[0][0] = new ArrayList();
            songs[0] = new HashSet<string>[1];
            songs[0][dynamicSideSongs] = new HashSet<string>();
            songNos[0] = new List<int>[1];
            ;
            songNos[0][dynamicSideSongs] = new List<int>();
//            songNos[0] = new List<int>();
            lapSt2 = 0;
            DateTime start2 = DateTime.Now;
            DateTime start3 = DateTime.Now;
            int sortedListMaxSize = length / limits + 1;
            SortedList<string, int>[] myStats = new SortedList<string, int>[sortedListMaxSize];
            myStats[0] = new SortedList<string, int>();
            while (sayac < length)
            {
                if (sayac % limits == 0)
                {
                    dynamicSideSongs++;
                    myStats[dynamicSideSongs] = new SortedList<string, int>();
                }

                average = (double) ((DateTime.Now - start).TotalSeconds / sayac);
                lapSt = DateTime.Now;
                lineTemp = lines[sayac];
                tempString = lineTemp.Split(separator);
                tempString2 = tempString[1].Split(separator2);
                playId = tempString[0];
                songId = tempString[1];
                clientId = tempString[2];
                timeId = tempString[3];
                datetimeId = timeId; 
                
                char separatorM = '/';
                char separatorM2 = ':';
                String[] tempDate = tempString[3].Split(separatorM);
                int year;
                int month;
                int day;
                int hour;
                int minute;
                int second;
                String[] tempDateMine = tempDate[2].Split(separator2);
                year = Int32.Parse(tempDateMine[0]);
                month = Int32.Parse(tempDate[1]);
                day = Int32.Parse(tempDate[0]);
                
                String temp;
                DateTime tempDatetime;
                double tempLap = (double) (DateTime.Now - lapSt).TotalSeconds;
                lapAvg = (double) ((DateTime.Now - start).TotalSeconds / sayac);
                lapSt2 = ((tempLap) + (lapSt2 * (sayac - 1))) / sayac;
                int counter = 0;
                DateTime start4 = DateTime.Now;
                start3 = DateTime.Now;
                Hashtable a = new Hashtable();

                String temp10 = clientId + "," + songId;
                if (day == 10&&month==8&&year==2016)
                {
                    if (myStats[dynamicSideSongs].ContainsKey(temp10))
                    {
                        int counterMine = 0;
                        foreach (KeyValuePair<string, int> kvp in myStats[dynamicSideSongs])
                        {
                            if (kvp.Key.Equals(temp10))
                            {
                                myStats[dynamicSideSongs][temp10]++;
                                break;
                            }

                            counterMine++;
                        }
                    }
                    else
                    {
                        myStats[dynamicSideSongs].Add(temp10, 1);
                    }
                }

                start3 = DateTime.Now;
                if(sayac%1000==0) {
                    Console.WriteLine("New Start Time " + start2 + ",End Time: " + DateTime.Now + ",LapSt: " +
                                                    (start3 - start2) + ",sayac: " +
                                                    sayac);}
                average = (double) ((DateTime.Now - start).TotalSeconds / sayac);
                previous = DateTime.Now;
                sayac++;
            }
            int temp20 = 0;
            Console.WriteLine("Start Time " + start + " End Time: " + DateTime.Now + " LapFinal: " +
                              (DateTime.Now - start));
            List<string> keys = new List<string>();
            List<KeyValuePair<string,int>> keyValues =new List<KeyValuePair<string, int>>();
            for (int internalCounter=0; internalCounter < myStats.Length; internalCounter+=2)
            {
                HashSet<string> firstSet = myStats[internalCounter].Keys.ToHashSet();
                List<string> internalKeys = new List<string>();
                if ((internalCounter + 1) != myStats.Length)
                {
                    firstSet.IntersectWith(myStats[internalCounter+1].Keys.ToHashSet());
                    HashSet<string> secondSet = myStats[internalCounter].Keys.ToHashSet();
                    secondSet.UnionWith(myStats[internalCounter+1].Keys.ToHashSet());
                    internalKeys = secondSet.ToList();
                }
                else
                {
                    internalKeys = firstSet.ToList();
                }
                internalKeys.AddRange(keys);
                internalKeys.Sort();
                HashSet<string> a1 = internalKeys.ToHashSet();
                internalKeys = a1.ToList();
                List<KeyValuePair<string, int>> internalKeyValues = new List<KeyValuePair<string, int>>();
                int keysCounter = 0;
                foreach (var keySet in internalKeys)
                {
                    int keyValue = 0;
                    int firstSetValue = 0;
                    int secondSetValue = 0;
                    if (myStats[internalCounter].TryGetValue(keySet, out firstSetValue))
                        keyValue += firstSetValue;
                    if ((internalCounter + 1) != myStats.Length)
                    {
                        if (myStats[internalCounter + 1].TryGetValue(keySet, out secondSetValue))
                            keyValue += secondSetValue;
                    }

                    KeyValuePair<string, int> pair = new KeyValuePair<string, int>(internalKeys[keysCounter], keyValue);

                    if (keyValues.Count != 0)
                    {
                            int temp1001;
                            temp1001 = keyValues.BinarySearch(pair, new myComparer());
                            if (temp1001 >= 0 && temp1001 < keyValues.Count)
                            {
                                KeyValuePair<string, int> pair2 = keyValues.ElementAt(temp1001);  
                                keyValue += pair2.Value;
                            } 
                    }
                    KeyValuePair<string, int> pair3 = new KeyValuePair<string, int>(pair.Key, keyValue);
                    internalKeyValues.Add(pair3);
                    keysCounter++;
                }
                keyValues.Clear();
                keyValues.AddRange(internalKeyValues);
                internalKeyValues.Clear();
                keys=internalKeys.ToList();
            }
        
            Console.WriteLine("Start Time "+ start + " End Time: " + DateTime.Now + " LapFinal: " + (DateTime.Now-start));
            temp20 = 0;
            foreach (var abc in keyValues)
            {
                temp20 += abc.Value;
            }
            Console.WriteLine();
            Console.WriteLine("TempKeyValues myStats.temp " + temp20);
            Console.WriteLine("Start Time "+ start + " End Time: " + DateTime.Now + " LapFinalFinal: " + (DateTime.Now-start));
            Console.WriteLine("Please enter client no and song no");
            String readLines = Console.ReadLine();
            String cli ="";
            String song = "-1";
            String searchOne="";
            if (readLines.Contains(' ')&& readLines.Length>0)
            {
                cli = readLines.Substring(0, readLines.IndexOf(' '));
                song = readLines.Substring(readLines.IndexOf(' ') + 1,
                    (readLines.Length - readLines.IndexOf(' ') - 1));
                searchOne = cli + ',' + song;
            }
            else if (readLines.Length == 0)
            {
                searchOne = "";
            }
            else
            {
                cli = readLines+',';
                searchOne = cli;
            }
            
            KeyValuePair<string, int> searchedOne = new KeyValuePair<string, int>(searchOne, 1);
            HashSet<KeyValuePair<int, int>> distinctSongsAndsClients = new HashSet<KeyValuePair<int, int>>();
            if (searchedOne.Key.Equals(""))
            {
                int userSongsCounter = 0;
                int totalPlays = 0;
                int totalClients = 0;
                string tempClient = ",";
                KeyValuePair<string, int> previous2 = new KeyValuePair<string, int>();
                previous2 = keyValues[0];
                foreach (KeyValuePair<string, int> kvp in keyValues)
                {
                    //userSongsCounter++;
                    tempClient = kvp.Key.Substring(0, kvp.Key.IndexOf(','));
                    if (!previous2.Key.Substring(0, previous2.Key.IndexOf(',')).Equals(tempClient))
                    {
                        totalClients++;
                        previous2=kvp;
                        KeyValuePair<int,int> tempSandC = new KeyValuePair<int, int>(userSongsCounter,1);
                        //int i = 0;
                        bool flagMine = true;
                        foreach (var tempVariable in distinctSongsAndsClients)
                        {
                            if (tempVariable.Key.Equals(tempSandC.Key))
                            {
                                int tempValue = tempVariable.Value;
                                tempValue++;
                                distinctSongsAndsClients.Remove(tempVariable);
                                KeyValuePair<int,int> temp2 = new KeyValuePair<int, int>(tempSandC.Key,tempValue);
                                distinctSongsAndsClients.Add(temp2);
                                flagMine = false;
                                break;
                            }
                        }
                        if (flagMine == true)
                        {
                            distinctSongsAndsClients.Add(tempSandC);
                        }
/*                        if (!distinctSongsAndsClients.Add(tempSandC))
                        {
                            int i = 0;
                            bool flagMine = true;
                            KeyValuePair<int,int> temp1 = new KeyValuePair<int, int>();
                            do
                            {
                                temp1=distinctSongsAndsClients.ElementAt(i);
                                if (temp1.Key.Equals(tempSandC.Key))
                                {
                                    int tempValue = temp1.Value;
                                    tempValue++;
                                    distinctSongsAndsClients.Remove(temp1);
                                    KeyValuePair<int,int> temp2 = new KeyValuePair<int, int>(temp1.Key,tempValue);
                                    distinctSongsAndsClients.Add(temp2);
                                    flagMine = false;
                                }
                                i++;
                            } while (i<distinctSongsAndsClients.Count&&flagMine == true);
                        }*/
                        userSongsCounter = 0;
                    }
                    userSongsCounter++;
                 }              
                 List<KeyValuePair<int,int> > myStatsSortedList= distinctSongsAndsClients.ToList();
                 List<int> newStats = new List<int>();
                 List<int> newStatsIndex = new List<int>();
                 foreach(var myVariable in myStatsSortedList)
                 {
                     newStats.Add(myVariable.Key);
                 }
                 newStats.Sort(new myComparer2());// Sort();
                 foreach (var myVariable in myStatsSortedList)
                 {
                     //newStats.Add(myVariable.Key);
                     int i = 0;
                     bool flag5 = true;
                     do
                     {
                         if (myVariable.Key.Equals(newStats.ElementAt(i)))
                         {
                             newStatsIndex.Add(myVariable.Value); //Sort();
                             flag5 = false;
                         }

                         i++;
                     } while (flag5 == true);
                 }
                 //                foreach (var myVariable in myStatsSortedList)
                 for(int i =0;i<newStats.Count;i++)
                 {
                     if(i.Equals(0))
                         Console.WriteLine("DISTINCT_PLAY_COUNT" + "\t" + "CLIENT_COUNT");
                     Console.WriteLine(" " + newStats.ElementAt(i) +"\t\t\t" + "  " + newStatsIndex.ElementAt(i));
                 }
            }
            else if (!cli.EndsWith(','))
            {

                int searchedIndex = keyValues.BinarySearch(searchedOne, new myComparer());
                int searchedValue = 0; 
                if (searchedIndex >= 0 && searchedIndex < keyValues.Count)
                {
                    KeyValuePair<string, int> pair2 = keyValues.ElementAt(searchedIndex);  
                    searchedValue = pair2.Value;
                    Console.WriteLine("Searched Client=" + cli + " song no=" + song + " this song is listened for " + searchedValue + " times");
                }
                else
                {
                    Console.WriteLine("It's not found on the list");
                }
            }
            else 
            {
                int allSongsCounter = 0;
                int totalPlays = 0;
                int totalClients = 0;
                string tempClient = ",";
                foreach (KeyValuePair<string, int> kvp in keyValues)
                {
                    if (kvp.Key.StartsWith(searchOne))
                    {
                        allSongsCounter++;
                        Console.WriteLine("Client=" + cli.Substring(0,cli.Length-1) + " song no=" + kvp.Key.Substring(kvp.Key.IndexOf(',')+1) + " this song is listened for " + kvp.Value + " times");
                        totalPlays += kvp.Value;
                    }
                }
                Console.WriteLine("Total of distinct songs listened for this user " + allSongsCounter + " total plays are " + totalPlays);
            }
        }
        public static void WaitingForSomeTime(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Thank you for waiting, operation continues");
        }
    }
}