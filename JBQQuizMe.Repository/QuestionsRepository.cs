using System;
using System.Collections.Generic;
using System.Linq;

namespace JBQQuizMe.Repository
{
    public class QuestionsRepository
    {
        static private List<QuestionInfo> _data;

        static QuestionsRepository()
        {
            _data = new List<QuestionInfo>
            {
                new QuestionInfo {
                    Number = 1,
                    Question = "What is the Bible?",
                    Answer = new List<string> { "The inspired Word of God and is His revelation to all people of himself and His plan of salvation." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "A collection of ancient songs." },
                        new List<string> { "The written word of the prophets of God." },
                        new List<string> { "A collection of ancient writing by church elders." },
                    },
                    Passage = null,
                    Type = null
                },
                new QuestionInfo {
                    Number = 2,
                    Question = "How many books are there in the Bible?",
                    Answer = new List<string> { "66" },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "Number"
                },
                new QuestionInfo {
                    Number = 3,
                    Question = "What are the two divisions of the Bible?",
                    Answer = new List<string> { "Old Testament and New Testament" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "The Front and Back Part" },
                        new List<string> { "The Beatitudes and Psalms" },
                        new List<string> { "The Gospel and the Law" },
                        new List<string> { "The Old and New Sections" },
                    },
                    Passage = null,
                    Type = null
                },
                new QuestionInfo {
                    Number = 4,
                    Question = "What does \"testament\" mean?",
                    Answer = new List<string> { "Covenant [contract or agreement]" },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "TermDefinition"
                },
                new QuestionInfo {
                    Number = 5,
                    Question = "How many books are in the Old Testament?",
                    Answer = new List<string> { "39" },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "Number"
                },
                new QuestionInfo {
                    Number = 6,
                    Question = "In what language was most of the Old Testament written?",
                    Answer = new List<string> { "Hebrew" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Greek" },
                        new List<string> { "Latin" },
                        new List<string> { "Egyptian" },
                        new List<string> { "Arabic" },
                        new List<string> { "Chinese" },
                    },
                    Passage = null,
                    Type = null
                },
                new QuestionInfo {
                    Number = 7,
                    Question = "How many books are in the New Testament?",
                    Answer = new List<string> { "27" },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "Number"
                },
                new QuestionInfo {
                    Number = 8,
                    Question = "In what language was most of the New Testament written?",
                    Answer = new List<string> { "Greek" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Hebrew" },
                        new List<string> { "Latin" },
                        new List<string> { "German" },
                        new List<string> { "Japanese" },
                        new List<string> { "Sanskrit" },
                    },
                    Passage = null,
                    Type = null
                },
                new QuestionInfo {
                    Number = 9,
                    Question = "About how many people did God inspire to write the Bible?",
                    Answer = new List<string> { "40" },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "Number"
                },
                new QuestionInfo {
                    Number = 10,
                    Question = "Approximately how many years did it take to write the Bible?",
                    Answer = new List<string> { "1,600 years" },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "Timespan"
                },
                new QuestionInfo {
                    Number = 11,
                    Question = "Which book of the Bible tells about the beginnings of the world?",
                    Answer = new List<string> { "Genesis" },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "BookOfTheBible"
                },
                new QuestionInfo {
                    Number = 12,
                    Question = "What are the four Gospels?",
                    Answer = new List<string> { "Matthew","Mark","Luke","John" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Peter","Paul","Mary","Joe" },
                        new List<string> { "Genesis","Exodus","Leviticus","Numbers" },
                        new List<string> { "Psalms","Proverbs","Romans","Acts" },
                        new List<string> { "1 John","2 John","3 John","Jude" },
                    },
                    Passage = null,
                    Type = null
                },
                new QuestionInfo {
                    Number = 13,
                    Question = "What does the word \"gospel\" mean?",
                    Answer = new List<string> { "Good news" },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "TermDefinition"
                },
                new QuestionInfo {
                    Number = 14,
                    Question = "What is the theme of the four Gospels?",
                    Answer = new List<string> { "The life and teaching of Jesus" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "The life and teachings of Moses" },
                        new List<string> { "The life of the apostels" },
                        new List<string> { "The revalation of the end times" },
                        new List<string> { "Eat, Sleep, Repeat" },
                    },
                    Passage = null,
                    Type = null
                },
                new QuestionInfo {
                    Number = 15,
                    Question = "Who wrote more books of the Bible than any other person?",
                    Answer = new List<string> { "Paul" },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 16,
                    Question = "Which book of the Bible tells about the beginnings of the Church?",
                    Answer = new List<string> { "Acts" },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "BookOfTheBible"
                },
                new QuestionInfo {
                    Number = 17,
                    Question = "Which New Testament book is composed almost entirely of prophecies of the future?",
                    Answer = new List<string> { "Revelation" },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "BookOfTheBible"
                },
                new QuestionInfo {
                    Number = 18,
                    Question = "Which of the Old Testament books is a collection of hymns and songs?",
                    Answer = new List<string> { "Psalms" },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "BookOfTheBible"
                },
                new QuestionInfo {
                    Number = 19,
                    Question = "Who wrote many of the Psalms?",
                    Answer = new List<string> { "King David" },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 20,
                    Question = "What is an epistle?",
                    Answer = new List<string> { "A letter sent by an apostle." },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "TermDefinition"
                },
                new QuestionInfo {
                    Number = 21,
                    Question = "What is the longest book of the Bible?",
                    Answer = new List<string> { "Psalms" },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "BookOfTheBible"
                },
                new QuestionInfo {
                    Number = 22,
                    Question = "What is the shortest chapter in the Bible?",
                    Answer = new List<string> { "Psalm 117" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Psalm 119" },
                        new List<string> { "Job 25" },
                        new List<string> { "Esther 10" },
                        new List<string> { "Psalm 133" },
                        new List<string> { "Genesis 1" },
                    },
                    Passage = null,
                    Type = null
                },
                new QuestionInfo {
                    Number = 23,
                    Question = "What is the longest chapter in the Bible?",
                    Answer = new List<string> { "Psalm 119" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Psalm 117" },
                        new List<string> { "Matthew 26" },
                        new List<string> { "Luke 1" },
                        new List<string> { "Revelation 22" },
                    },
                    Passage = null,
                    Type = null
                },
                new QuestionInfo {
                    Number = 24,
                    Question = "Where did the universe come from?",
                    Answer = new List<string> { "Genesis 1:1 \"In the beginning God created the heavens and the earth.\"" },
                    WrongAnswers = null,
                    Passage = "Genesis 1:1",
                    Type = "DirectBibleQuote"
                },
                new QuestionInfo {
                    Number = 25,
                    Question = "Who were the first man and first woman?",
                    Answer = new List<string> { "Adam and Eve" },
                    WrongAnswers = null,
                    Passage = "Genesis 3:20",
                    Type = "TwoPersons"
                },
                new QuestionInfo {
                    Number = 26,
                    Question = "How are people different from animals?",
                    Answer = new List<string> { "God created people in His own image." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "God gave people the ability to stand." },
                        new List<string> { "God gave people brains." },
                        new List<string> { "God gave people the ability to talk." },
                        new List<string> { "God create people in the image of the angels." },
                    },
                    Passage = "Genesis 1:27",
                    Type = null
                },
                new QuestionInfo {
                    Number = 27,
                    Question = "Who were the first two brothers?",
                    Answer = new List<string> { "Cain and Abel" },
                    WrongAnswers = null,
                    Passage = "Genesis 4:1-2",
                    Type = "TwoPersons"
                },
                new QuestionInfo {
                    Number = 28,
                    Question = "Who was the first murderer?",
                    Answer = new List<string> { "Cain" },
                    WrongAnswers = null,
                    Passage = "Genesis 4:8",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 29,
                    Question = "How did sin enter the world?",
                    Answer = new List<string> { "Through the disobedience of Adam and Eve" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Through the disobedience of Cain and Abel" },
                        new List<string> { "Through the obedience of Noah" },
                        new List<string> { "Through the disobedience of the angels" },
                        new List<string> { "Through the Internet" },
                    },
                    Passage = "Genesis 3:1-19;Romans 5:14",
                    Type = null
                },
                new QuestionInfo {
                    Number = 30,
                    Question = "The account of man's first sin mentioned what two trees?",
                    Answer = new List<string> { "The tree of the knowledge of good and evil","The tree of life" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "The tree of widsom","The tree of wealth" },
                        new List<string> { "The tree of peace","The tree of health" },
                        new List<string> { "The tree of love","The bush of fire" },
                    },
                    Passage = "Genesis 2:17; 3:24",
                    Type = null
                },
                new QuestionInfo {
                    Number = 31,
                    Question = "What man walked with God until God took him to heaven without dying?",
                    Answer = new List<string> { "Enoch" },
                    WrongAnswers = null,
                    Passage = "Genesis 5:23-24",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 32,
                    Question = "Who lived longer than any other person, and how long did he live?",
                    Answer = new List<string> { "Methuselah--969 years" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Lamech--1001 years" },
                        new List<string> { "Jared--962 years" },
                        new List<string> { "Noah--950 years" },
                        new List<string> { "Mahalalel--895" },
                    },
                    Passage = "Genesis 5:27",
                    Type = null
                },
                new QuestionInfo {
                    Number = 33,
                    Question = "Why did God send a flood upon the earth?",
                    Answer = new List<string> { "Because people were so wicked and they thought about evil all the time" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Because people were sometimes wicked" },
                        new List<string> { "Because people did not pick up their trash" },
                        new List<string> { "Because people did not read the Bible" },
                        new List<string> { "Because too many people left their sinks on" },
                    },
                    Passage = "Genesis 6:5",
                    Type = null
                },
                new QuestionInfo {
                    Number = 34,
                    Question = "Whom did God spare from the Great Flood?",
                    Answer = new List<string> { "Noah and his family" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Moses and his family" },
                        new List<string> { "Noah and his town" },
                        new List<string> { "Noah and his wife" },
                        new List<string> { "Moses and his pet dog" },
                    },
                    Passage = "Genesis 7:7",
                    Type = null
                },
                new QuestionInfo {
                    Number = 35,
                    Question = "Who were the three sons of Noah?",
                    Answer = new List<string> { "Shem","Ham","Japheth" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Peter","James","John" },
                        new List<string> { "Noah Jr","Noah II","Noah IV" },
                        new List<string> { "Peter","Paul","Mary" },
                    },
                    Passage = "Genesis 7:13",
                    Type = null
                },
                new QuestionInfo {
                    Number = 36,
                    Question = "When the Flood came, how long did it rain?",
                    Answer = new List<string> { "Forty days and nights" },
                    WrongAnswers = null,
                    Passage = "Genesis 7:12",
                    Type = "Timespan"
                },
                new QuestionInfo {
                    Number = 37,
                    Question = "What was the meaning of the first rainbow?",
                    Answer = new List<string> { "It was God's promise that the world would never again be destroyed by a flood." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "It was God's promise that the world would never be destroyed by fire." },
                        new List<string> { "It was God's promise that the world would be destroyed every 1000 years." },
                        new List<string> { "It was God's promise that world would NEVER be destroyed." },
                    },
                    Passage = "Genesis 9:14-15",
                    Type = null
                },
                new QuestionInfo {
                    Number = 38,
                    Question = "After the Flood, how did the people rebel against God?",
                    Answer = new List<string> { "By building a tower that reached into the sky to make themselves famous" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "By building a ladder that reached into the sky" },
                        new List<string> { "By digging the deepest hole to make themselves famous" },
                        new List<string> { "By launching a rocket to talk to God" },
                    },
                    Passage = "Genesis 11:4",
                    Type = null
                },
                new QuestionInfo {
                    Number = 39,
                    Question = "How did God judge the people who built the tower of Babel?",
                    Answer = new List<string> { "God confused the people with different languages so they couldn't understand one another." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "God confused the people with different foods so they would not eat with each other." },
                        new List<string> { "God took all their building tools away." },
                        new List<string> { "God destroyed the tower of Babel." },
                        new List<string> { "God did not judge them." },
                    },
                    Passage = "Genesis 11:7",
                    Type = null
                },
                new QuestionInfo {
                    Number = 40,
                    Question = "How did God test Abraham's faith when He asked him to leave his home?",
                    Answer = new List<string> { "By asking Abraham to follow Him without telling him where He would lead him" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "By asking Abraham to give all his money away" },
                        new List<string> { "By asking Abraham to burn his home" },
                        new List<string> { "By asking Abraham to walk without shoes" },
                    },
                    Passage = "Genesis 12:1-6; Hebrews 11:8",
                    Type = null
                },
                new QuestionInfo {
                    Number = 41,
                    Question = "Who was Abraham's nephew?",
                    Answer = new List<string> { "Lot" },
                    WrongAnswers = null,
                    Passage = "Genesis 12:4-5",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 42,
                    Question = "What was the original name of the country God promised to Abraham?",
                    Answer = new List<string> { "Canaan" },
                    WrongAnswers = null,
                    Passage = "Genesis 12:5",
                    Type = "Place"
                },
                new QuestionInfo {
                    Number = 43,
                    Question = "Who was Abraham's wife?",
                    Answer = new List<string> { "Sarah" },
                    WrongAnswers = null,
                    Passage = "Genesis 17:15",
                    Type = "Woman"
                },
                new QuestionInfo {
                    Number = 44,
                    Question = "To what country did Abraham go in time of famine?",
                    Answer = new List<string> { "Egypt" },
                    WrongAnswers = null,
                    Passage = "Genesis 12:10",
                    Type = "Place"
                },
                new QuestionInfo {
                    Number = 45,
                    Question = "Why was it wrong for Lot to live in Sodom?",
                    Answer = new List<string> { "Because the people of Sodom were very wicked and constantly sinned against the Lord." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Because Lot was not born in Sodom." },
                        new List<string> { "Because Sodom did not have salt." },
                        new List<string> { "Because Lot was a prophet of God." },
                    },
                    Passage = "Genesis 13:12-13; 14:12",
                    Type = null
                },
                new QuestionInfo {
                    Number = 46,
                    Question = "Who was Melchizedek?",
                    Answer = new List<string> { "Priest of God and King of Salem" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Priest of God and King of Dan" },
                        new List<string> { "Prophet of Judea" },
                        new List<string> { "King of Bath" },
                    },
                    Passage = "Genesis 14:18",
                    Type = null
                },
                new QuestionInfo {
                    Number = 47,
                    Question = "What was the name of the son born to Abraham and Hagar?",
                    Answer = new List<string> { "Ishmael" },
                    WrongAnswers = null,
                    Passage = "Genesis 16:15-16",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 48,
                    Question = "What two cities did God destroy with fire because of their great wickedness?",
                    Answer = new List<string> { "Sodom and Gomorrah" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Ephesus and Corinth" },
                        new List<string> { "Hebron and Debir" },
                        new List<string> { "Minneapolis and St. Paul" },
                    },
                    Passage = "Genesis 19:24-25",
                    Type = null
                },
                new QuestionInfo {
                    Number = 49,
                    Question = "What was the name of the son born to Abraham and Sarah?",
                    Answer = new List<string> { "Isaac" },
                    WrongAnswers = null,
                    Passage = "Genesis 21:1-3",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 50,
                    Question = "How old were Abraham and Sarah when Isaac was born?",
                    Answer = new List<string> { "Abraham was one hundred and Sarah was ninety years old." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Abraham was sixty and Sarah was fourty-five years old." },
                        new List<string> { "Abraham was twenty-three and Sarah was twenty years old." },
                        new List<string> { "Abraham and Sarah were both ninety years old." },
                    },
                    Passage = "Genesis 17:17; 21:1-5",
                    Type = null
                },
                new QuestionInfo {
                    Number = 51,
                    Question = "Who was Isaac's wife?",
                    Answer = new List<string> { "Rebekah" },
                    WrongAnswers = null,
                    Passage = "Genesis 24:67",
                    Type = "Woman"
                },
                new QuestionInfo {
                    Number = 52,
                    Question = "Who were the twin sons of Isaac and Rebekah?",
                    Answer = new List<string> { "Esau and Jacob" },
                    WrongAnswers = null,
                    Passage = "Genesis 25:20-26",
                    Type = "TwoPersons"
                },
                new QuestionInfo {
                    Number = 53,
                    Question = "What did Esau sell to Jacob?",
                    Answer = new List<string> { "His birthright" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "His donkey" },
                        new List<string> { "His house" },
                        new List<string> { "His robe" },
                        new List<string> { "His sheep" },
                    },
                    Passage = "Genesis 25:29-34",
                    Type = null
                },
                new QuestionInfo {
                    Number = 54,
                    Question = "How did Jacob obtain the blessing of the firstborn son instead of Esau?",
                    Answer = new List<string> { "By making his father, Isaac, think he was Esau" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "By making his mother, Rebekah, think he was Esau" },
                        new List<string> { "By faking his birth certificate" },
                        new List<string> { "By feeding his father, Isaac, his favorite food" },
                    },
                    Passage = "Genesis 27:1-29",
                    Type = null
                },
                new QuestionInfo {
                    Number = 55,
                    Question = "Where did Jacob have a dream of a stairway reaching to heaven?",
                    Answer = new List<string> { "Bethel" },
                    WrongAnswers = null,
                    Passage = "Genesis 28:10-19",
                    Type = "Place"
                },
                new QuestionInfo {
                    Number = 56,
                    Question = "Who was the mother of Joseph and Benjamin?",
                    Answer = new List<string> { "Rachel" },
                    WrongAnswers = null,
                    Passage = "Genesis 30:22-24; 35:16-18",
                    Type = "Woman"
                },
                new QuestionInfo {
                    Number = 57,
                    Question = "What new name did God give to Jacob after he wrestled with God?",
                    Answer = new List<string> { "Israel" },
                    WrongAnswers = null,
                    Passage = "Genesis 32:24-28",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 58,
                    Question = "What special meaning did Joseph's dreams have?",
                    Answer = new List<string> { "He would be a great ruler someday, and his family would bow down to him." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "He would be thrown into prison." },
                        new List<string> { "He would become very wealthy and support his family." },
                        new List<string> { "He would leave his family forever." },
                    },
                    Passage = "Genesis 37:5-11",
                    Type = null
                },
                new QuestionInfo {
                    Number = 59,
                    Question = "How did Jacob show his special love for Joseph?",
                    Answer = new List<string> { "By giving him a beautiful robe [coat of many colors]" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "By giving him a white robe" },
                        new List<string> { "By giving him a gold trimmed coat" },
                        new List<string> { "By giving him a coat of invisibility" },
                    },
                    Passage = "Genesis 37:3, 23",
                    Type = null
                },
                new QuestionInfo {
                    Number = 60,
                    Question = "Into what country was Joseph sold as a slave?",
                    Answer = new List<string> { "Egypt" },
                    WrongAnswers = null,
                    Passage = "Genesis 37:36",
                    Type = "Place"
                },
                new QuestionInfo {
                    Number = 61,
                    Question = "Who was Joseph's first master in Egypt?",
                    Answer = new List<string> { "Potiphar" },
                    WrongAnswers = null,
                    Passage = "Genesis 39:1",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 62,
                    Question = "What happened to Joseph when he refused to commit sin with his master's wife?",
                    Answer = new List<string> { "He was put into prison." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "He was praised by the master." },
                        new List<string> { "He fled his master." },
                        new List<string> { "He became the chief cup bearer." },
                    },
                    Passage = "Genesis 39:20",
                    Type = null
                },
                new QuestionInfo {
                    Number = 63,
                    Question = "Whose dreams did Joseph interpret while in prison?",
                    Answer = new List<string> { "Pharaoh's baker and cupbearer" },
                    WrongAnswers = null,
                    Passage = "Genesis 40:1-22",
                    Type = "TwoPersons"
                },
                new QuestionInfo {
                    Number = 64,
                    Question = "What did Joseph say was the meaning of the king's dream?",
                    Answer = new List<string> { "Seven good years would be followed by seven years of famine." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Fourteen years of famine." },
                        new List<string> { "Six good months would be followed by six months of famine." },
                        new List<string> { "The king would gain more wealth." },
                    },
                    Passage = "Genesis 41:25-27",
                    Type = null
                },
                new QuestionInfo {
                    Number = 65,
                    Question = "Whom did Pharaoh appoint to prepare for the famine?",
                    Answer = new List<string> { "Joseph" },
                    WrongAnswers = null,
                    Passage = "Genesis 41:33-46",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 66,
                    Question = "What are the names of the two sons of Joseph?",
                    Answer = new List<string> { "Ephraim and Manasseh" },
                    WrongAnswers = null,
                    Passage = "Genesis 41:50-52",
                    Type = "TwoPersons"
                },
                new QuestionInfo {
                    Number = 67,
                    Question = "Why did Joseph's brothers go to Egypt?",
                    Answer = new List<string> { "To buy food" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "To sell food" },
                        new List<string> { "To sell a donkey" },
                        new List<string> { "To find Joseph" },
                        new List<string> { "To steal a golden cup" },
                    },
                    Passage = "Genesis 42:3-5",
                    Type = null
                },
                new QuestionInfo {
                    Number = 68,
                    Question = "Where did Jacob and his family settle in Egypt?",
                    Answer = new List<string> { "Goshen" },
                    WrongAnswers = null,
                    Passage = "Genesis 46:33-34",
                    Type = "Place"
                },
                new QuestionInfo {
                    Number = 69,
                    Question = "Who was the baby that Pharaoh's daughter found floating in the river?",
                    Answer = new List<string> { "Moses" },
                    WrongAnswers = null,
                    Passage = "Exodus 2:1-10",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 70,
                    Question = "Why did Moses flee from Egypt?",
                    Answer = new List<string> { "Because it was known that he had killed an Egyptian who mistreated an Israelite" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Because it was known that he had killed an Israelite who beat an Egyptian" },
                        new List<string> { "Because he freed the slaves" },
                        new List<string> { "Because he disobeyed pharoh " },
                    },
                    Passage = "Exodus 2:11-15",
                    Type = null
                },
                new QuestionInfo {
                    Number = 71,
                    Question = "Who was Moses' father-in-law and what was his position?",
                    Answer = new List<string> { "Jethro; priest of Midian" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Job; prophet of Midian" },
                        new List<string> { "Matthew; tax collector" },
                        new List<string> { "Benjamin; cupbearer" },
                        new List<string> { "Samson; lion tamer" },
                    },
                    Passage = "Exodus 3:1",
                    Type = null
                },
                new QuestionInfo {
                    Number = 72,
                    Question = "Where did God appear to Moses out of the burning bush?",
                    Answer = new List<string> { "Mount Sinai" },
                    WrongAnswers = null,
                    Passage = "Exodus 3:1-2",
                    Type = "Place"
                },
                new QuestionInfo {
                    Number = 73,
                    Question = "What promise did God make to Moses at the burning bush?",
                    Answer = new List<string> { "That God would rescue the Israelites out of Egypt" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "That God would let the Israelites conquer Egypt" },
                        new List<string> { "That God would bring the Israelites great wealth" },
                        new List<string> { "That God would let the Israelites stay in Egypt another 7 years" },
                    },
                    Passage = "Exodus 3:8-10",
                    Type = null
                },
                new QuestionInfo {
                    Number = 74,
                    Question = "How did God persuade Pharaoh to let the Israelites go?",
                    Answer = new List<string> { "By sending ten plagues upon the land of Egypt." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "By combat between Pharaoh and Moses." },
                        new List<string> { "By bribery." },
                        new List<string> { "By sending one big plague." },
                        new List<string> { "By saying 'please'." },
                    },
                    Passage = "Exodus 3:17-20; chapters 7 through 11",
                    Type = null
                },
                new QuestionInfo {
                    Number = 75,
                    Question = "Whom did God give Moses to help him in bringing the Israelites out of Egypt?",
                    Answer = new List<string> { "Moses' brother Aaron" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Moses' wife Zipporah" },
                        new List<string> { "Moses' half brother twice removed Bubba" },
                        new List<string> { "A stranger from the desert" },
                        new List<string> { "Nobody" },
                    },
                    Passage = "Exodus 4:14",
                    Type = null
                },
                new QuestionInfo {
                    Number = 76,
                    Question = "What was the tenth and last plague that fell upon Egypt?",
                    Answer = new List<string> { "The death of the firstborn" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "A plague of frogs" },
                        new List<string> { "A plague of crows" },
                        new List<string> { "The death of pharaoh" },
                        new List<string> { "A great flood" },
                    },
                    Passage = "Exodus 11:1-7",
                    Type = null
                },
                new QuestionInfo {
                    Number = 77,
                    Question = "What feast did God establish to remember the Israelites' deliverance from Egypt?",
                    Answer = new List<string> { "Passover" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Overpass" },
                        new List<string> { "Christmas" },
                        new List<string> { "Deliverance Day" },
                        new List<string> { "Purim" },
                    },
                    Passage = "Exodus 12:3-11",
                    Type = null
                },
                new QuestionInfo {
                    Number = 78,
                    Question = "By what miracle did the Israelites leave the land of Egypt?",
                    Answer = new List<string> { "The parting of the Red Sea" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "The parting of the Sea of Galilee" },
                        new List<string> { "By stopping a sandstorm" },
                        new List<string> { "By God providing a herd of oxen" },
                    },
                    Passage = "Exodus 14:13-22",
                    Type = null
                },
                new QuestionInfo {
                    Number = 79,
                    Question = "What happened to the Egyptians who tried to follow the Israelites through the Red Sea?",
                    Answer = new List<string> { "They all drowned." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "They crossed the sea." },
                        new List<string> { "They were trapped on the other side of the sea." },
                        new List<string> { "They were stuck on an island." },
                        new List<string> { "They were rescued by boats." },
                    },
                    Passage = "Exodus 14:23-28",
                    Type = null
                },
                new QuestionInfo {
                    Number = 80,
                    Question = "Who was the sister of Moses?",
                    Answer = new List<string> { "Miriam" },
                    WrongAnswers = null,
                    Passage = "Numbers 26:59",
                    Type = "Woman"
                },
                new QuestionInfo {
                    Number = 81,
                    Question = "How did God change the bitter water of Marah into good water?",
                    Answer = new List<string> { "By showing Moses a piece of wood to throw into the water" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "By Moses pouring oil into the water" },
                        new List<string> { "By Moses dipping his staff into the water" },
                        new List<string> { "By Moses putting burnt fig leaves into the water" },
                    },
                    Passage = "Exodus 15:23-25",
                    Type = null
                },
                new QuestionInfo {
                    Number = 82,
                    Question = "How did God provide bread for the Israelites in the wilderness?",
                    Answer = new List<string> { "By sending manna" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "By causing wheat to grow" },
                        new List<string> { "By getting it from other countries" },
                        new List<string> { "Sending loaves by birds" },
                    },
                    Passage = "Exodus 16:31",
                    Type = null
                },
                new QuestionInfo {
                    Number = 83,
                    Question = "What miracle did God perform for Moses at Rephidim?",
                    Answer = new List<string> { "God brought water from a rock." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "God healed a blind man." },
                        new List<string> { "God sent mana from heaven." },
                        new List<string> { "God stopped the sun and moon." },
                    },
                    Passage = "Exodus 17:1-6",
                    Type = null
                },
                new QuestionInfo {
                    Number = 84,
                    Question = "How did Aaron and Hur help Moses gain the victory over the Amalekites?",
                    Answer = new List<string> { "By holding up Moses' hands" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "By defending Moses against the Amalekites" },
                        new List<string> { "By making sure Moses did not fall over in the wind" },
                        new List<string> { "By bringing Moses water to drink" },
                    },
                    Passage = "Exodus 17:8-13",
                    Type = null
                },
                new QuestionInfo {
                    Number = 85,
                    Question = "On what mountain did God give Moses the Ten Commandments?",
                    Answer = new List<string> { "Mount Sinai" },
                    WrongAnswers = null,
                    Passage = "Exodus 19:1 to 20:17",
                    Type = "Place"
                },
                new QuestionInfo {
                    Number = 86,
                    Question = "Which is the first of the Ten Commandments?",
                    Answer = new List<string> { "Exodus 20:3 \"You must not have any other god but me.\"" },
                    WrongAnswers = null,
                    Passage = "Exodus 20:3",
                    Type = "DirectBibleQuote"
                },
                new QuestionInfo {
                    Number = 87,
                    Question = "Which of the Ten Commandments prohibits the worshipping of idols?",
                    Answer = new List<string> { "Exodus 20:4 \"You must not make for yourself an idol of any kind.\"" },
                    WrongAnswers = null,
                    Passage = "Exodus 20:4",
                    Type = "DirectBibleQuote"
                },
                new QuestionInfo {
                    Number = 88,
                    Question = "Which of the Ten Commandments prohibits cursing and swearing?",
                    Answer = new List<string> { "Exodus 20:7 \"You must not misuse the name of the Lord your God.\"" },
                    WrongAnswers = null,
                    Passage = "Exodus 20:7",
                    Type = "DirectBibleQuote"
                },
                new QuestionInfo {
                    Number = 89,
                    Question = "Which of the Ten Commandments sets aside one day each week as special unto God?",
                    Answer = new List<string> { "Exodus 20:8 \"Remember to observe the Sabbath day by keeping it holy.\"" },
                    WrongAnswers = null,
                    Passage = "Exodus 20:8",
                    Type = "DirectBibleQuote"
                },
                new QuestionInfo {
                    Number = 90,
                    Question = "What did Paul call \"the first commandment with promise\"?",
                    Answer = new List<string> { "\"Honor your father and mother.\"" },
                    WrongAnswers = null,
                    Passage = "Exodus 20:12; Ephesians 6:2-3",
                    Type = "DirectBibleQuote"
                },
                new QuestionInfo {
                    Number = 91,
                    Question = "Which of the Ten Commandments protects the sacredness of human life?",
                    Answer = new List<string> { "\"You must not murder.\"" },
                    WrongAnswers = null,
                    Passage = "Exodus 20:13",
                    Type = "DirectBibleQuote"
                },
                new QuestionInfo {
                    Number = 92,
                    Question = "Which of the Ten Commandments protects the sacredness of marriage?",
                    Answer = new List<string> { "\"You must not commit adultery.\"" },
                    WrongAnswers = null,
                    Passage = "Exodus 20:14",
                    Type = "DirectBibleQuote"
                },
                new QuestionInfo {
                    Number = 93,
                    Question = "Which of the Ten Commandments protects our right to own possessions?",
                    Answer = new List<string> { "\"You must not steal.\"" },
                    WrongAnswers = null,
                    Passage = "Exodus 20:15",
                    Type = "DirectBibleQuote"
                },
                new QuestionInfo {
                    Number = 94,
                    Question = "Which of the Ten Commandments prohibits lying?",
                    Answer = new List<string> { "\"You must not testify falsely against your neighbor.\"" },
                    WrongAnswers = null,
                    Passage = "Exodus 20:16",
                    Type = "DirectBibleQuote"
                },
                new QuestionInfo {
                    Number = 95,
                    Question = "Which of the Ten Commandments forbids wrong desires?",
                    Answer = new List<string> { "\"You must not covet anything that belongs to your neighbor.\"" },
                    WrongAnswers = null,
                    Passage = "Exodus 20:17",
                    Type = "DirectBibleQuote"
                },
                new QuestionInfo {
                    Number = 96,
                    Question = "In which book and chapter of the Bible do we find the first record of the Ten Commandments?",
                    Answer = new List<string> { "Exodus 20" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Genesis 1" },
                        new List<string> { "Exodus 10" },
                        new List<string> { "Psalms 37" },
                        new List<string> { "Numbers 20" },
                    },
                    Passage = "Exodus 20",
                    Type = null
                },
                new QuestionInfo {
                    Number = 97,
                    Question = "What did the Israelites build in which to worship God while they were in the wilderness?",
                    Answer = new List<string> { "The tabernacle" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "The prayer tent" },
                        new List<string> { "The meditation tent" },
                        new List<string> { "The sanctuary" },
                        new List<string> { "The great hall" },
                    },
                    Passage = "Exodus 25:8-9; 26:30",
                    Type = null
                },
                new QuestionInfo {
                    Number = 98,
                    Question = "What sin did Aaron and the Israelites commit at Mount Sinai?",
                    Answer = new List<string> { "Making and worshipping the idol of the golden calf" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Making and worshipping the idol of the silver goat" },
                        new List<string> { "The breaking of the ten commandments" },
                        new List<string> { "Leading the people away from Mount Sinai" },
                    },
                    Passage = "Exodus 32:2-6",
                    Type = null
                },
                new QuestionInfo {
                    Number = 99,
                    Question = "From which of the tribes of Israel were the priests chosen?",
                    Answer = new List<string> { "Levi" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Judah" },
                        new List<string> { "Jospeh" },
                        new List<string> { "Simeon" },
                        new List<string> { "Issachar" },
                        new List<string> { "Asher" },
                    },
                    Passage = "Deuteronomy 18:1-5; Hebrews 7:11-19",
                    Type = null
                },
                new QuestionInfo {
                    Number = 100,
                    Question = "What was the main purpose of the sacrifices and offerings made by the Israelites?",
                    Answer = new List<string> { "To purify them from their sins" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "To heal the sick" },
                        new List<string> { "To provide for a good harvest" },
                        new List<string> { "To purify the air" },
                    },
                    Passage = "Leviticus 5:1-6",
                    Type = null
                },
                new QuestionInfo {
                    Number = 101,
                    Question = "What did God use to lead the Israelites in the wilderness?",
                    Answer = new List<string> { "A cloud by day and a pillar of fire by night" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "A flock of birds" },
                        new List<string> { "A map" },
                        new List<string> { "An orb of light" },
                        new List<string> { "A GPS" },
                    },
                    Passage = "Numbers 9:15-23",
                    Type = null
                },
                new QuestionInfo {
                    Number = 102,
                    Question = "Why were the twelve spies sent by Moses into Canaan?",
                    Answer = new List<string> { "To see what kind of land it was and what kind of people lived there" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "To see what army was present" },
                        new List<string> { "To see what buildings were there" },
                        new List<string> { "To see who the rulers were" },
                        new List<string> { "To see if the land was good" },
                    },
                    Passage = "Numbers 13:16-20",
                    Type = null
                },
                new QuestionInfo {
                    Number = 103,
                    Question = "What evidence did the spies bring back to show that Canaan was a good land?",
                    Answer = new List<string> { "They brought fruit from the land." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "They brought a captive." },
                        new List<string> { "They brought wild pigs from the land." },
                        new List<string> { "They brough a fig leaf." },
                        new List<string> { "They brought clear water." },
                    },
                    Passage = "Numbers 13:23-24",
                    Type = null
                },
                new QuestionInfo {
                    Number = 104,
                    Question = "Which two of the twelve spies said the Israelites could capture the land of Canaan?",
                    Answer = new List<string> { "Joshua and Caleb" },
                    WrongAnswers = null,
                    Passage = "Numbers 14:1-9",
                    Type = "TwoPersons"
                },
                new QuestionInfo {
                    Number = 105,
                    Question = "How many years did the Israelites wander in the wilderness?",
                    Answer = new List<string> { "Forty years" },
                    WrongAnswers = null,
                    Passage = "Numbers 14:33-34",
                    Type = "Timespan"
                },
                new QuestionInfo {
                    Number = 106,
                    Question = "How did God prove to the Israelites that Moses and Aaron were His chosen leaders?",
                    Answer = new List<string> { "He caused Aaron's staff to sprout, bud, and blossom." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "By casting lots." },
                        new List<string> { "By way of a prophet." },
                        new List<string> { "By sending down a dove from heaven." },
                        new List<string> { "Eeny, meeny, miny, moe." },
                    },
                    Passage = "Numbers 17:1-10",
                    Type = null
                },
                new QuestionInfo {
                    Number = 107,
                    Question = "How did Moses disobey God when the water came from the rock at Meribah?",
                    Answer = new List<string> { "He struck the rock instead of speaking to it." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "He poured oil on the rock instead of speaking to it." },
                        new List<string> { "He spoke to the rock instead of striking it." },
                        new List<string> { "He had Aaron speak to the rock instead." },
                    },
                    Passage = "Numbers 20:7-13",
                    Type = null
                },
                new QuestionInfo {
                    Number = 108,
                    Question = "How did God provide healing for the Israelites when they were bitten by the snakes?",
                    Answer = new List<string> { "God told Moses to make a bronze snake that the people could look at and be healed." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "God told Moses to make a gold calf that the people could look at and be healed." },
                        new List<string> { "God provided mana." },
                        new List<string> { "God had Moses tell the people to drink from the river." },
                    },
                    Passage = "Numbers 21:5-9",
                    Type = null
                },
                new QuestionInfo {
                    Number = 109,
                    Question = "Whom did God appoint to be the leader of Israel after Moses?",
                    Answer = new List<string> { "Joshua" },
                    WrongAnswers = null,
                    Passage = "Numbers 27:18-23",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 110,
                    Question = "Why was Moses not allowed to go into the land of Canaan?",
                    Answer = new List<string> { "Because he failed to trust God and demonstrate God's holiness to the Israelites at Meribah" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Because he failed to worship God and demonstrate God's holiness to the Babylonians" },
                        new List<string> { "Because he failed to pray to God" },
                        new List<string> { "Because he didn't pay his taxes" },
                    },
                    Passage = "Numbers 20:1-13; Deuteronomy 32:48-52",
                    Type = null
                },
                new QuestionInfo {
                    Number = 111,
                    Question = "From what mountain did Moses see the Promised Land?",
                    Answer = new List<string> { "Nebo" },
                    WrongAnswers = null,
                    Passage = "Deuteronomy 34:1-4",
                    Type = "Place"
                },
                new QuestionInfo {
                    Number = 112,
                    Question = "How old was Moses when he died?",
                    Answer = new List<string> { "120 years" },
                    WrongAnswers = null,
                    Passage = "Deuteronomy 34:7",
                    Type = "Timespan"
                },
                new QuestionInfo {
                    Number = 113,
                    Question = "Who were the only two men who left Egypt and entered Canaan?",
                    Answer = new List<string> { "Joshua and Caleb" },
                    WrongAnswers = null,
                    Passage = "Numbers 26:65",
                    Type = "TwoPersons"
                },
                new QuestionInfo {
                    Number = 114,
                    Question = "Who protected the spies Joshua sent to Jericho?",
                    Answer = new List<string> { "Rahab" },
                    WrongAnswers = null,
                    Passage = "Joshua 2:1-6",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 115,
                    Question = "How did Rahab mark her house so she would be protected when Jericho was captured?",
                    Answer = new List<string> { "By placing a scarlet rope in the window of her house" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "By placing a lamp in the window of her house" },
                        new List<string> { "By marking the doorway of her house" },
                        new List<string> { "By singing a particular song in her house" },
                    },
                    Passage = "Joshua 2:18-21",
                    Type = null
                },
                new QuestionInfo {
                    Number = 116,
                    Question = "By what miracle did the Israelites enter the Promised Land?",
                    Answer = new List<string> { "God stopped the flow of the Jordan River during its flood stage." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "God parted the Red Sea." },
                        new List<string> { "God sent a boat to cross the Jordan River." },
                        new List<string> { "God sent a whale to take the Israelites across the Jordan River." },
                    },
                    Passage = "Joshua 3:14-17",
                    Type = null
                },
                new QuestionInfo {
                    Number = 117,
                    Question = "How many times did the Israelites march around the walls of Jericho?",
                    Answer = new List<string> { "Thirteen--once each day for six days and seven times on the seventh day" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Seven--once each day for seven days" },
                        new List<string> { "Seven--seven times in one day" },
                        new List<string> { "Just one time" },
                    },
                    Passage = "Joshua 6:3-4",
                    Type = null
                },
                new QuestionInfo {
                    Number = 118,
                    Question = "What happened at Jericho when the Israelites shouted at Joshua's command?",
                    Answer = new List<string> { "The walls of Jericho collapsed." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "The gates of Jericho opened." },
                        new List<string> { "The people of Jericho fled." },
                        new List<string> { "Fire came down upon Jericho." },
                    },
                    Passage = "Joshua 6:20",
                    Type = null
                },
                new QuestionInfo {
                    Number = 119,
                    Question = "Whose sin caused the defeat at Ai?",
                    Answer = new List<string> { "Achan's" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Joshua's" },
                        new List<string> { "Karmi's" },
                        new List<string> { "Mose's" },
                    },
                    Passage = "Joshua 7:1-4; 11-12",
                    Type = null
                },
                new QuestionInfo {
                    Number = 120,
                    Question = "What miracle occurred when Joshua fought at Gibeon?",
                    Answer = new List<string> { "The sun and the moon stood still." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "The sea parted." },
                        new List<string> { "Fire came down from the sky." },
                        new List<string> { "The Amorites were frozen." },
                    },
                    Passage = "Joshua 10:12-13",
                    Type = null
                },
                new QuestionInfo {
                    Number = 121,
                    Question = "Who defeated the Midianites with only three hundred men?",
                    Answer = new List<string> { "Gideon" },
                    WrongAnswers = null,
                    Passage = "Judges 7:7",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 122,
                    Question = "Which of the judges was very strong?",
                    Answer = new List<string> { "Samson" },
                    WrongAnswers = null,
                    Passage = "Judges 14:5-6",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 123,
                    Question = "What woman tricked Samson into telling her the secret of his strength?",
                    Answer = new List<string> { "Delilah" },
                    WrongAnswers = null,
                    Passage = "Judges 16:4-21",
                    Type = "Woman"
                },
                new QuestionInfo {
                    Number = 124,
                    Question = "What Gentile girl decided to serve God because she loved her mother-in-law, Naomi?",
                    Answer = new List<string> { "Ruth" },
                    WrongAnswers = null,
                    Passage = "Ruth 1:14-19",
                    Type = "Woman"
                },
                new QuestionInfo {
                    Number = 125,
                    Question = "What descendant of Ruth became king of Israel?",
                    Answer = new List<string> { "David" },
                    WrongAnswers = null,
                    Passage = "Ruth 4:13-22",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 126,
                    Question = "What child heard the voice of God speak to him during the night?",
                    Answer = new List<string> { "Samuel" },
                    WrongAnswers = null,
                    Passage = "1 Samuel 3:2-10",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 127,
                    Question = "Upon what priest did God tell Samuel to pronounce judgment?",
                    Answer = new List<string> { "Eli" },
                    WrongAnswers = null,
                    Passage = "1 Samuel 3:11-14",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 128,
                    Question = "As described in Hebrews, what was the ark of the covenant?",
                    Answer = new List<string> { "The sacred box which contained the stone tablets of the Ten Commandments, the gold jar of manna, and Aaron's staff that had sprouted leaves" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "The original copy of the Bible" },
                        new List<string> { "The robe of Moses and Aaron's shepherd staff" },
                        new List<string> { "The spoils of Egypt from the exodus" },
                    },
                    Passage = "Hebrews 9:4",
                    Type = null
                },
                new QuestionInfo {
                    Number = 129,
                    Question = "Why did the Israelites want a king instead of a judge?",
                    Answer = new List<string> { "Because they wanted to be like other nations" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Because they ran out of judges" },
                        new List<string> { "Because God instructed them to do so" },
                        new List<string> { "Because only kings wear a crown" },
                    },
                    Passage = "1 Samuel 8:4-5",
                    Type = null
                },
                new QuestionInfo {
                    Number = 130,
                    Question = "Who was the first king of Israel?",
                    Answer = new List<string> { "Saul" },
                    WrongAnswers = null,
                    Passage = "1 Samuel 10:17-25",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 131,
                    Question = "Why did God reject Saul as king of Israel?",
                    Answer = new List<string> { "Saul rejected God's command." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Someone else was better." },
                        new List<string> { "Israel no longer needed a king." },
                        new List<string> { "Saul moved away from Israel." },
                    },
                    Passage = "1 Samuel 15:22-23",
                    Type = null
                },
                new QuestionInfo {
                    Number = 132,
                    Question = "Whom did God choose to replace Saul as king of Israel?",
                    Answer = new List<string> { "David" },
                    WrongAnswers = null,
                    Passage = "1 Samuel 16:1-13",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 133,
                    Question = "What giant did David kill?",
                    Answer = new List<string> { "Goliath" },
                    WrongAnswers = null,
                    Passage = "1 Samuel 17:23-25, 48-51",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 134,
                    Question = "Who was the commander of David's army?",
                    Answer = new List<string> { "Joab" },
                    WrongAnswers = null,
                    Passage = "1 Kings 1:19",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 135,
                    Question = "Why did David refuse to kill King Saul?",
                    Answer = new List<string> { "Because God had chosen Saul to be king" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Because he was too well guarded" },
                        new List<string> { "Because of his friend Jonathan (Saul's son)" },
                        new List<string> { "Because he did not have a sword" },
                    },
                    Passage = "1 Samuel 24:5-7",
                    Type = null
                },
                new QuestionInfo {
                    Number = 136,
                    Question = "How long did David rule as king?",
                    Answer = new List<string> { "Forty years" },
                    WrongAnswers = null,
                    Passage = "2 Samuel 5-4-5",
                    Type = "Timespan"
                },
                new QuestionInfo {
                    Number = 137,
                    Question = "Which son of Saul was David's best friend?",
                    Answer = new List<string> { "Jonathan" },
                    WrongAnswers = null,
                    Passage = "1 Samuel 18:1",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 138,
                    Question = "Why did David show kindness to Mephibosheth?",
                    Answer = new List<string> { "Because Mephibosheth was Jonathan's son" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Because Mephibosheth is a cool name" },
                        new List<string> { "Because God instructed David to do so" },
                        new List<string> { "Because David was now king" },
                    },
                    Passage = "2 Samuel 9:1-7",
                    Type = null
                },
                new QuestionInfo {
                    Number = 139,
                    Question = "Which of David's sons tried to take the kingdom from him?",
                    Answer = new List<string> { "Absalom" },
                    WrongAnswers = null,
                    Passage = "2 Samuel 15:1-12",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 140,
                    Question = "When did David say life begins?",
                    Answer = new List<string> { "In the womb" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "In the crib" },
                        new List<string> { "At one year of age" },
                        new List<string> { "At age 50" },
                    },
                    Passage = "Psalm 139:13-16",
                    Type = null
                },
                new QuestionInfo {
                    Number = 141,
                    Question = "Whom did God tell David to choose to be king after his death?",
                    Answer = new List<string> { "Solomon" },
                    WrongAnswers = null,
                    Passage = "1 Kings 1:32-35; 1 Chronicles 22:9",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 142,
                    Question = "What did Solomon ask God to give him when he became king?",
                    Answer = new List<string> { "Wisdom" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Strength" },
                        new List<string> { "Power" },
                        new List<string> { "Agility" },
                        new List<string> { "Kindness" },
                        new List<string> { "Money" },
                    },
                    Passage = "1 Kings 3:5-14",
                    Type = null
                },
                new QuestionInfo {
                    Number = 143,
                    Question = "What building did Solomon erect for God?",
                    Answer = new List<string> { "The temple of the Lord" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "The tallest tower" },
                        new List<string> { "A great storehouse" },
                        new List<string> { "A great palace" },
                    },
                    Passage = "1 Kings 6:1-2",
                    Type = null
                },
                new QuestionInfo {
                    Number = 144,
                    Question = "What queen came from a long distance to visit Solomon?",
                    Answer = new List<string> { "Sheba" },
                    WrongAnswers = null,
                    Passage = "1 Kings 10:1",
                    Type = "Woman"
                },
                new QuestionInfo {
                    Number = 145,
                    Question = "What happened to the kingdom of Israel upon the death of Solomon?",
                    Answer = new List<string> { "It was divided into the kingdoms of Israel and Judah." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "It joined with a neighboring country." },
                        new List<string> { "It was conquered." },
                        new List<string> { "It was divided into twelve kingdoms." },
                        new List<string> { "It was dissolved." },
                    },
                    Passage = "1 Kings 4:20-21; 11:28-43; 12:16-20",
                    Type = null
                },
                new QuestionInfo {
                    Number = 146,
                    Question = "Why did Jeroboam establish idol worship in the northern kingdom of Israel?",
                    Answer = new List<string> { "So the people wouldn't go to Jerusalem to offer sacrifices" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "So the people wouldn't leave the country" },
                        new List<string> { "So the people would not revolt" },
                        new List<string> { "So Jeroboam would be able to worship idols" },
                    },
                    Passage = "1 Kings 12:26-30",
                    Type = null
                },
                new QuestionInfo {
                    Number = 147,
                    Question = "On Mount Carmel, why did Elijah ask God to consume the sacrifice with fire?",
                    Answer = new List<string> { "So that all of Israel would know that God was really God" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "To impress the other kingdoms" },
                        new List<string> { "So that all of Israel would follow Elijah" },
                        new List<string> { "Because Elijah did not have a way to start a fire" },
                    },
                    Passage = "1 Kings 18:30-39",
                    Type = null
                },
                new QuestionInfo {
                    Number = 148,
                    Question = "Who were the evil king and queen of Israel during the time of Elijah?",
                    Answer = new List<string> { "Ahab and Jezebel" },
                    WrongAnswers = null,
                    Passage = "1 Kings 21:4-5",
                    Type = "TwoPersons"
                },
                new QuestionInfo {
                    Number = 149,
                    Question = "Whom did God take directly to heaven in a whirlwind?",
                    Answer = new List<string> { "Elijah" },
                    WrongAnswers = null,
                    Passage = "2 Kings 2:11",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 150,
                    Question = "What prophet succeeded Elijah?",
                    Answer = new List<string> { "Elisha" },
                    WrongAnswers = null,
                    Passage = "2 Kings 2:15",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 151,
                    Question = "What Syrian officer was healed of leprosy by bathing in the Jordan River at Elisha's command?",
                    Answer = new List<string> { "Naaman" },
                    WrongAnswers = null,
                    Passage = "2 Kings 5:10-14",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 152,
                    Question = "To whom did God give a sign of the sun moving backwards to show him that he was healed?",
                    Answer = new List<string> { "Hezekiah" },
                    WrongAnswers = null,
                    Passage = "2 Kings 20:8-11",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 153,
                    Question = "To what city were many of the people of Judah taken as captives?",
                    Answer = new List<string> { "Babylon" },
                    WrongAnswers = null,
                    Passage = "2 Kings 24:10-16",
                    Type = "Place"
                },
                new QuestionInfo {
                    Number = 154,
                    Question = "What king of Babylon conquered Jerusalem and the Kingdom of Judah?",
                    Answer = new List<string> { "Nebuchadnezzar" },
                    WrongAnswers = null,
                    Passage = "2 Kings 24:10-16",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 155,
                    Question = "When the people returned to Jerusalem from captivity in Babylon, who oversaw the rebuilding of the temple?",
                    Answer = new List<string> { "Zerubbabel" },
                    WrongAnswers = null,
                    Passage = "Ezra 3:8",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 156,
                    Question = "When the people returned to Jerusalem from captivity in Babylon, who oversaw the rebuilding of the walls of the city?",
                    Answer = new List<string> { "Nehemiah" },
                    WrongAnswers = null,
                    Passage = "Nehemiah 2:4-8",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 157,
                    Question = "Who was the Jewish girl who became the wife of the king of Persia?",
                    Answer = new List<string> { "Esther" },
                    WrongAnswers = null,
                    Passage = "Esther 2:16-17",
                    Type = "Woman"
                },
                new QuestionInfo {
                    Number = 158,
                    Question = "How did Esther save the lives of the Jewish people?",
                    Answer = new List<string> { "By asking her husband, king of Persia, to spare their lives" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "By asking her cousin Mordecai to spare their lives" },
                        new List<string> { "By moving the Jewish people to another land" },
                        new List<string> { "By hiding the Jewish people" },
                        new List<string> { "By putting them on a boat and sailing across the sea" },
                    },
                    Passage = "Esther 7:1-6",
                    Type = null
                },
                new QuestionInfo {
                    Number = 159,
                    Question = "What man lost all of his possessions and his health but remained true to God?",
                    Answer = new List<string> { "Job" },
                    WrongAnswers = null,
                    Passage = "Job 1:7-22",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 160,
                    Question = "How did God reward Job for his faithfulness?",
                    Answer = new List<string> { "God gave him as many children and twice as many possessions as he had had before his trial." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "God gave hime one child and a new home." },
                        new List<string> { "God gave him a kingdom." },
                        new List<string> { "God gave him the land of his enemies." },
                    },
                    Passage = "Job 42:10-13",
                    Type = null
                },
                new QuestionInfo {
                    Number = 161,
                    Question = "Who was called the weeping prophet?",
                    Answer = new List<string> { "Jeremiah" },
                    WrongAnswers = null,
                    Passage = "Jeremiah 9:1",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 162,
                    Question = "Who interpreted a famous dream for King Nebuchadnezzar?",
                    Answer = new List<string> { "Daniel" },
                    WrongAnswers = null,
                    Passage = "Daniel 2:27-29",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 163,
                    Question = "Why were Shadrach, Meshach, and Abednego thrown into a blazing furnace?",
                    Answer = new List<string> { "They refused to worship the gold statue set up by the king." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "They refused to give their money to the king." },
                        new List<string> { "They refused to make a gold statue for the king." },
                        new List<string> { "They stole from the king." },
                    },
                    Passage = "Daniel 3:14-23",
                    Type = null
                },
                new QuestionInfo {
                    Number = 164,
                    Question = "What did Daniel do when the king decreed he could no longer pray to his God?",
                    Answer = new List<string> { "He continued to pray just as he always did." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "He stopped praying." },
                        new List<string> { "He spoke out against the king." },
                        new List<string> { "He left the city." },
                    },
                    Passage = "Daniel 6:10",
                    Type = null
                },
                new QuestionInfo {
                    Number = 165,
                    Question = "What happened to Daniel when he continued to pray to God instead of to the king?",
                    Answer = new List<string> { "He was thrown into the lions' den." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "He was made a prophet to the king." },
                        new List<string> { "He was thrown into a field of sheep." },
                        new List<string> { "He was banished from the kingdom." },
                    },
                    Passage = "Daniel 6:4-16",
                    Type = null
                },
                new QuestionInfo {
                    Number = 166,
                    Question = "What was the meaning of the handwriting on the wall at Belshazzar's drunken party?",
                    Answer = new List<string> { "That Belshazzar's kingdom was about to be conquered" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "That Belshazzar's kingdom would grow" },
                        new List<string> { "That Belshazzar needed more wine" },
                        new List<string> { "That Belshazzar's gold would be lost" },
                    },
                    Passage = "Daniel 5:25-31",
                    Type = null
                },
                new QuestionInfo {
                    Number = 167,
                    Question = "Who was swallowed by a great fish when he ran away from doing God's will?",
                    Answer = new List<string> { "Jonah" },
                    WrongAnswers = null,
                    Passage = "Jonah 1:17",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 168,
                    Question = "What happened when Jonah preached to the people of Ninevah?",
                    Answer = new List<string> { "The people repented and God forgave them." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "The people went back to their wicked ways." },
                        new List<string> { "The people left the city." },
                        new List<string> { "The people killed Jonah." },
                    },
                    Passage = "Jonah 3:5-10",
                    Type = null
                },
                new QuestionInfo {
                    Number = 169,
                    Question = "Where did Micah say the Messiah would be born?",
                    Answer = new List<string> { "Bethlehem" },
                    WrongAnswers = null,
                    Passage = "Micah 5:2",
                    Type = "Place"
                },
                new QuestionInfo {
                    Number = 170,
                    Question = "According to the prophet Zechariah, where will Jesus' feet stand when He returns to the earth?",
                    Answer = new List<string> { "The Mount of Olives" },
                    WrongAnswers = null,
                    Passage = "Zechariah 14:4",
                    Type = "Place"
                },
                new QuestionInfo {
                    Number = 171,
                    Question = "Who told Mary she would be the mother of the Messiah?",
                    Answer = new List<string> { "The angel Gabriel" },
                    WrongAnswers = null,
                    Passage = "Luke 1:26-33",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 172,
                    Question = "To whom was the virgin Mary engaged to be married?",
                    Answer = new List<string> { "Joseph" },
                    WrongAnswers = null,
                    Passage = "Matthew 1:18",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 173,
                    Question = "Who were the first persons, other than Joseph and Mary, to hear that Jesus had been born?",
                    Answer = new List<string> { "Shepherds" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Wise Men" },
                        new List<string> { "King Herod and his court" },
                        new List<string> { "The Apostles" },
                    },
                    Passage = "Luke 2:8-16",
                    Type = null
                },
                new QuestionInfo {
                    Number = 174,
                    Question = "What two groups of men worshipped the Christ child?",
                    Answer = new List<string> { "Shepherds and Wise Men" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Wise Men and Prophets" },
                        new List<string> { "Shepherds and Holy Men" },
                        new List<string> { "Prophets and Tax Collectors" },
                    },
                    Passage = "Matthew 2:1-2;Luke 2:8-17",
                    Type = null
                },
                new QuestionInfo {
                    Number = 175,
                    Question = "When the Wise Men came seeking Jesus, what question did they ask?",
                    Answer = new List<string> { "Matthew 2:2 \"Where is the newborn king of the Jews?\"" },
                    WrongAnswers = null,
                    Passage = "Matthew 2:2",
                    Type = "DirectBibleQuote"
                },
                new QuestionInfo {
                    Number = 176,
                    Question = "Who was king over Judea when Jesus was born?",
                    Answer = new List<string> { "Herod" },
                    WrongAnswers = null,
                    Passage = "Matthew 2:3",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 177,
                    Question = "How did the Wise Men find Jesus?",
                    Answer = new List<string> { "They followed His star to where He was." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "They were given a map." },
                        new List<string> { "They followed the moon to where He was." },
                        new List<string> { "They followed a pillar of fire." },
                        new List<string> { "They were given a GPS." },
                    },
                    Passage = "Matthew 2:2-9",
                    Type = null
                },
                new QuestionInfo {
                    Number = 178,
                    Question = "What gifts were given to Jesus by the Wise Men?",
                    Answer = new List<string> { "Gold","Frankincense","Myrrh" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Gold","Silver","Bronze" },
                        new List<string> { "Rubies","Diamonds","Emeralds" },
                        new List<string> { "Gift cards" },
                    },
                    Passage = "Matthew 2:11",
                    Type = null
                },
                new QuestionInfo {
                    Number = 179,
                    Question = "Where did Jesus live as He was growing up?",
                    Answer = new List<string> { "Nazareth" },
                    WrongAnswers = null,
                    Passage = "Matthew 2:23",
                    Type = "Place"
                },
                new QuestionInfo {
                    Number = 180,
                    Question = "Whom did God send to prepare the way for Jesus?",
                    Answer = new List<string> { "John the Baptist" },
                    WrongAnswers = null,
                    Passage = "John 3:26-28",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 181,
                    Question = "About how old was Jesus when He began His public ministry?",
                    Answer = new List<string> { "30 years" },
                    WrongAnswers = null,
                    Passage = "Luke 3:23",
                    Type = "Timespan"
                },
                new QuestionInfo {
                    Number = 182,
                    Question = "About how long did Jesus preach and teach before His crucifixion?",
                    Answer = new List<string> { "3 1/2 years" },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "Timespan"
                },
                new QuestionInfo {
                    Number = 183,
                    Question = "With what words did John the Baptist introduce Jesus?",
                    Answer = new List<string> { "John 1:29 \"Look! The Lamb of God who takes away the sin of the world!\"" },
                    WrongAnswers = null,
                    Passage = "John 1:29",
                    Type = "DirectBibleQuote"
                },
                new QuestionInfo {
                    Number = 184,
                    Question = "How did John the Baptist describe the way Jesus would baptize?",
                    Answer = new List<string> { "With the Holy Spirit and with fire" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "With a dove" },
                        new List<string> { "With holy oil" },
                        new List<string> { "With water of the Jordan River" },
                    },
                    Passage = "Matthew 3:11",
                    Type = null
                },
                new QuestionInfo {
                    Number = 185,
                    Question = "Which of the disciples was a tax collector?",
                    Answer = new List<string> { "Matthew" },
                    WrongAnswers = null,
                    Passage = "Matthew 10:3",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 186,
                    Question = "After Andrew met Jesus, what did he tell his brother Simon Peter?",
                    Answer = new List<string> { "\"We have found the Messiah.\"" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "\"We have found the Son of God.\"" },
                        new List<string> { "\"We have found the great healer.\"" },
                        new List<string> { "\"We have found the fisher of men.\"" },
                    },
                    Passage = "John 1:40-41",
                    Type = null
                },
                new QuestionInfo {
                    Number = 187,
                    Question = "What was Jesus' first miracle?",
                    Answer = new List<string> { "Turning water into wine at the wedding in Cana" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Turning wine into water" },
                        new List<string> { "Pulling a rabbit out of hat" },
                        new List<string> { "Healing the blind man" },
                        new List<string> { "Calming a storm on the sea" },
                    },
                    Passage = "John 2:1-11",
                    Type = null
                },
                new QuestionInfo {
                    Number = 188,
                    Question = "What ruler of the Jews came to Jesus by night seeking the way to eternal life?",
                    Answer = new List<string> { "Nicodemus" },
                    WrongAnswers = null,
                    Passage = "John 3:1-2",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 189,
                    Question = "Where did John the Baptist baptize Jesus?",
                    Answer = new List<string> { "In the Jordan River" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "In the Red Sea" },
                        new List<string> { "In a small creek" },
                        new List<string> { "In the Tigris River" },
                        new List<string> { "In a puddle of water" },
                    },
                    Passage = "Matthew 3:13",
                    Type = null
                },
                new QuestionInfo {
                    Number = 190,
                    Question = "How did God show His approval of Jesus at His baptism?",
                    Answer = new List<string> { "The Holy Spirit descended on Him and the Father said, \"This is my dearly loved Son, who brings me great joy.\"" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "\"This is my Son of the line of David.\"" },
                        new List<string> { "\"This is my Son, who shall bring peace to the world.\"" },
                        new List<string> { "\"This is my dearly loved Son, who brings me great sorrow.\"" },
                    },
                    Passage = "Matthew 3:16-17; Luke 3:21-22",
                    Type = null
                },
                new QuestionInfo {
                    Number = 191,
                    Question = "During Jesus' temptation, how long did He go without eating?",
                    Answer = new List<string> { "Forty days and nights" },
                    WrongAnswers = null,
                    Passage = "Matthew 4:2; Luke 4:2",
                    Type = "Timespan"
                },
                new QuestionInfo {
                    Number = 192,
                    Question = "Who were the first four apostles Jesus called to follow Him?",
                    Answer = new List<string> { "Peter","Andrew","James","John" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Noah","Moses","Adam","Eve" },
                        new List<string> { "Timothy","Judas","Luke","Simon" },
                        new List<string> { "James","John","Judas","Jude" },
                    },
                    Passage = "Matthew 4:18-22",
                    Type = null
                },
                new QuestionInfo {
                    Number = 193,
                    Question = "What do we call the first statements of the Sermon on the Mount which all begin with the words, \"God blesses\"?",
                    Answer = new List<string> { "The Beatitudes" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "The Beatles" },
                        new List<string> { "The Gospels" },
                        new List<string> { "The New Testament" },
                        new List<string> { "The Old Testament" },
                    },
                    Passage = "Matthew 5:2-11",
                    Type = null
                },
                new QuestionInfo {
                    Number = 194,
                    Question = "How did Jesus prove His power over nature?",
                    Answer = new List<string> { "By calming a storm on the Sea of Galilee" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "By stopping the sun and moon" },
                        new List<string> { "By starting a storm on the Sea of Galilee" },
                        new List<string> { "By destroying a mountain" },
                    },
                    Passage = "Matthew 8:23-27",
                    Type = null
                },
                new QuestionInfo {
                    Number = 195,
                    Question = "What strange gift did King Herod give to his stepdaughter?",
                    Answer = new List<string> { "The head of John the Baptist" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "The thumb of John the Baptist" },
                        new List<string> { "A shubbery" },
                        new List<string> { "The head of a lion" },
                    },
                    Passage = "Matthew 14:6-11",
                    Type = null
                },
                new QuestionInfo {
                    Number = 196,
                    Question = "What revelation of himself did Jesus give to Peter, James and John on a high mountain?",
                    Answer = new List<string> { "Jesus' appearance was transformed, and he talked with Moses and Elijah." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Jesus' appearance looked the same." },
                        new List<string> { "Jesus talked with Noah." },
                        new List<string> { "Jesus' cloths were made of gold." },
                    },
                    Passage = "Matthew 17:1-8",
                    Type = null
                },
                new QuestionInfo {
                    Number = 197,
                    Question = "Why did the rich young leader fail to follow Jesus?",
                    Answer = new List<string> { "He loved the things he owned more than he loved Jesus." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "He loved his wife more than he loved Jesus." },
                        new List<string> { "He loved his sheep more than he loved Jesus." },
                        new List<string> { "He loved his father more than he loved Jesus." },
                    },
                    Passage = "Matthew 19:16-22; Luke 18:18-23",
                    Type = null
                },
                new QuestionInfo {
                    Number = 198,
                    Question = "What did Jesus prophesy would happen to the stones of the temple?",
                    Answer = new List<string> { "Not one stone would be left on top of another" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "All of them would be wet" },
                        new List<string> { "All of them would be burnt" },
                        new List<string> { "Not one stone would be lost" },
                    },
                    Passage = "Mark 13:1-2",
                    Type = null
                },
                new QuestionInfo {
                    Number = 199,
                    Question = "What great statement did Peter make about Jesus?",
                    Answer = new List<string> { "Matthew 16:16 \"You are the Messiah, the Son of the living God.\"" },
                    WrongAnswers = null,
                    Passage = "Matthew 16:16",
                    Type = "DirectBibleQuote"
                },
                new QuestionInfo {
                    Number = 200,
                    Question = "Which three of the disciples were Jesus' closest friends?",
                    Answer = new List<string> { "Peter","James","John" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Peter","Paul","Mary" },
                        new List<string> { "Shem","Ham","Japeth" },
                        new List<string> { "Timothy","Andrew","Jude" },
                        new List<string> { "John","John Jr.","John III" },
                    },
                    Passage = "Matthew 17:1 ",
                    Type = null
                },
                new QuestionInfo {
                    Number = 201,
                    Question = "Who did Jesus say was like the foolish man who built his house upon sand?",
                    Answer = new List<string> { "Those who hear His teachings but do not obey them" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Those who hear His teachings and follow them" },
                        new List<string> { "Those who do not listen" },
                        new List<string> { "Those who talk too much" },
                    },
                    Passage = "Matthew 7:26",
                    Type = null
                },
                new QuestionInfo {
                    Number = 202,
                    Question = "Who did Jesus say was like the wise man who built his house upon the rock?",
                    Answer = new List<string> { "Those who hear His teachings and follow them" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Those who hear His teachings but do not obey them" },
                        new List<string> { "Those who do not listen" },
                        new List<string> { "Those who talk too much" },
                    },
                    Passage = "Matthew 7:24",
                    Type = null
                },
                new QuestionInfo {
                    Number = 203,
                    Question = "In Jesus' parable, who helped the man who had been beaten and robbed?",
                    Answer = new List<string> { "The Good Samaritan" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "The Bad Samaritan" },
                        new List<string> { "The Good Persian" },
                        new List<string> { "The Babylonian" },
                        new List<string> { "The New Yorker" },
                    },
                    Passage = "Luke 10:30-37",
                    Type = null
                },
                new QuestionInfo {
                    Number = 204,
                    Question = "In the Parable of the Sower, to what did Jesus compare the seed?",
                    Answer = new List<string> { "The Word of God" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "The Tree of Life" },
                        new List<string> { "The Fruit of Salvation" },
                        new List<string> { "The Faith of the Holy" },
                    },
                    Passage = "Mark 4:14",
                    Type = null
                },
                new QuestionInfo {
                    Number = 205,
                    Question = "What did Jesus teach about material possessions?",
                    Answer = new List<string> { "Don't be greedy" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Don't be wasteful" },
                        new List<string> { "Don't convet your neighbors possessions" },
                        new List<string> { "Do not steal" },
                        new List<string> { "Don't misplace them" },
                        new List<string> { "Do not sell them" },
                    },
                    Passage = "Luke 12:15",
                    Type = null
                },
                new QuestionInfo {
                    Number = 206,
                    Question = "What did Jesus do in healing the man born blind?",
                    Answer = new List<string> { "He put mud on his eyes and told him to go and wash it off." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "He put oil on his eyes and told him to go and wash it off." },
                        new List<string> { "He fed the man fish." },
                        new List<string> { "He told the man's family to pray." },
                        new List<string> { "He gave the man eye drops." },
                    },
                    Passage = "John 9:1-7",
                    Type = null
                },
                new QuestionInfo {
                    Number = 207,
                    Question = "Which of Jesus' parables tells us that God is willing to forgive and restore the sinner who repents?",
                    Answer = new List<string> { "The Parable of the Prodigal Son" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "The Good Samaritan" },
                        new List<string> { "The Mustard Seed" },
                        new List<string> { "The Lost Sheep" },
                        new List<string> { "The Two Sons" },
                    },
                    Passage = "Luke 15:11-32",
                    Type = null
                },
                new QuestionInfo {
                    Number = 208,
                    Question = "How did Jesus answer those who asked if it was right for them to pay taxes to Caesar?",
                    Answer = new List<string> { "Give Caesar what belongs to Caesar, and give God what belongs to God." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Do not give Caesar anything." },
                        new List<string> { "Give to God after what is given to Caesar." },
                        new List<string> { "Give to God what belongs to Caesar." },
                        new List<string> { "Give Caesar everything." },
                    },
                    Passage = "Matthew 22:15-22",
                    Type = null
                },
                new QuestionInfo {
                    Number = 209,
                    Question = "How did Jesus feed five thousand men, plus women and children?",
                    Answer = new List<string> { "He multiplied five loaves and two fish from a boy's lunch." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "He and the disciples fished all night." },
                        new List<string> { "He ordered food from another town." },
                        new List<string> { "Mana fell from the sky." },
                    },
                    Passage = "Matthew 14:13-21; Mark 6:32-44; Luke 9:10-17; John 6:1-13",
                    Type = null
                },
                new QuestionInfo {
                    Number = 210,
                    Question = "Who climbed a tree in order to see Jesus?",
                    Answer = new List<string> { "Zacchaeus" },
                    WrongAnswers = null,
                    Passage = "Luke 19:1-6",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 211,
                    Question = "How did Jesus come into Jerusalem at the Triumphal Entry?",
                    Answer = new List<string> { "Jesus came riding on the colt of a donkey." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Jesus walked through the back gate." },
                        new List<string> { "Jesus flew in." },
                        new List<string> { "Jesus was snuck in by the disciples." },
                    },
                    Passage = "Matthew 21:2-5; Luke 19:29-35; John 12:14-15",
                    Type = null
                },
                new QuestionInfo {
                    Number = 212,
                    Question = "How did Jesus teach His disciples humility at the Last Supper?",
                    Answer = new List<string> { "He washed the disciples' feet." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "He washed the disciples' hands." },
                        new List<string> { "He served the disciples' food." },
                        new List<string> { "He gave the disciples money." },
                        new List<string> { "He took food from the disciples." },
                    },
                    Passage = "John 13:1-17",
                    Type = null
                },
                new QuestionInfo {
                    Number = 213,
                    Question = "Where did Jesus pray the night before His crucifixion?",
                    Answer = new List<string> { "Gethsemane" },
                    WrongAnswers = null,
                    Passage = "Matthew 26:36",
                    Type = "Place"
                },
                new QuestionInfo {
                    Number = 214,
                    Question = "Which apostle betrayed Jesus?",
                    Answer = new List<string> { "Judas Iscariot" },
                    WrongAnswers = null,
                    Passage = "Matthew 26:17-25, 45-49",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 215,
                    Question = "In betraying Jesus, how did Judas show the soldiers who Jesus was?",
                    Answer = new List<string> { "He kissed Jesus" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "He hugged Jesus" },
                        new List<string> { "He gave the soldiers a note" },
                        new List<string> { "He pointed to Jesus" },
                    },
                    Passage = "Matthew 26:49",
                    Type = null
                },
                new QuestionInfo {
                    Number = 216,
                    Question = "What did Jesus prophesy Peter would do on the night of His betrayal?",
                    Answer = new List<string> { "Peter would deny knowing Jesus three times." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Peter would pray." },
                        new List<string> { "Peter would stop Judas." },
                        new List<string> { "Peter would leave the country." },
                        new List<string> { "Peter would battle the Romans." },
                    },
                    Passage = "Matthew 26:34",
                    Type = null
                },
                new QuestionInfo {
                    Number = 217,
                    Question = "What person did the people ask Pilate to release instead of Jesus?",
                    Answer = new List<string> { "Barabbas" },
                    WrongAnswers = null,
                    Passage = "Matthew 27:15-21",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 218,
                    Question = "What does the word \"Golgotha\" mean?",
                    Answer = new List<string> { "The Place of the Skull" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "The Burial Place of Goliath" },
                        new List<string> { "The Place of Flowers" },
                        new List<string> { "The Place of the Sword" },
                    },
                    Passage = "Matthew 27:33",
                    Type = null
                },
                new QuestionInfo {
                    Number = 219,
                    Question = "What title did Pilate have placed on Jesus' cross?",
                    Answer = new List<string> { "[Jesus of Nazareth], the King of the Jews" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "[Jesus of Nazareth], a Criminal" },
                        new List<string> { "King of the Crown of Thorns" },
                        new List<string> { "[Jesus of Bethlehem], the King of the Jews" },
                    },
                    Passage = "Matthew 27:37; Mark 15:26; John 19:19",
                    Type = null
                },
                new QuestionInfo {
                    Number = 220,
                    Question = "How did Jesus die?",
                    Answer = new List<string> { "He was crucified, or nailed to a cross." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "He was killed by the sword." },
                        new List<string> { "He was killed by a mob." },
                        new List<string> { "He was killed by a wild animal." },
                        new List<string> { "He died from food poisoning." },
                    },
                    Passage = "Matthew 27:35",
                    Type = null
                },
                new QuestionInfo {
                    Number = 221,
                    Question = "What happened in the realm of nature when Jesus was crucified?",
                    Answer = new List<string> { "The sun became dark for three hours and there was an earthquake." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "The seas turned red and boiled." },
                        new List<string> { "The birds stopped singing for three hours and there was a storm." },
                        new List<string> { "All flowers withered and died." },
                        new List<string> { "The sky turned pink." },
                    },
                    Passage = "Matthew 27:45, 51",
                    Type = null
                },
                new QuestionInfo {
                    Number = 222,
                    Question = "What did the Roman officer who had been in charge of Jesus' execution say about Jesus?",
                    Answer = new List<string> { "\"This man truly was the Son of God!\"" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "\"He was not a criminal!\"" },
                        new List<string> { "\"The false prophet is dead!\"" },
                        new List<string> { "\"We should not have done this!\"" },
                    },
                    Passage = "Mark 15:39",
                    Type = null
                },
                new QuestionInfo {
                    Number = 223,
                    Question = "Who buried Jesus?",
                    Answer = new List<string> { "Joseph of Arimathea and Nicodemus" },
                    WrongAnswers = null,
                    Passage = "John 19:38-39",
                    Type = "TwoPersons"
                },
                new QuestionInfo {
                    Number = 224,
                    Question = "Who was the first person to see Jesus after He was resurrected?",
                    Answer = new List<string> { "Mary Magdalene" },
                    WrongAnswers = null,
                    Passage = "John 20:1-18",
                    Type = "Woman"
                },
                new QuestionInfo {
                    Number = 225,
                    Question = "How was the way made for the women to get inside the tomb of Jesus?",
                    Answer = new List<string> { "An angel had rolled away the stone." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "A group of men rolled away the stone." },
                        new List<string> { "An angel blew up the stone." },
                        new List<string> { "The stone disappeared." },
                    },
                    Passage = "Matthew 28:2",
                    Type = null
                },
                new QuestionInfo {
                    Number = 226,
                    Question = "Who was the disciple who at first doubted Jesus' resurrection?",
                    Answer = new List<string> { "Thomas" },
                    WrongAnswers = null,
                    Passage = "John 20:24-29",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 227,
                    Question = "After Jesus walked and talked with His apostles following His resurrection, what happened to Him?",
                    Answer = new List<string> { "He was taken up into a cloud until they could no longer see Him." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "He appeared to masses to give a sermon." },
                        new List<string> { "He walked into the ocean until they could not longer see Him." },
                        new List<string> { "A dove came down and he dissappeared." },
                    },
                    Passage = "Acts 1:1-9",
                    Type = null
                },
                new QuestionInfo {
                    Number = 228,
                    Question = "Who was chosen to replace Judas as an apostle?",
                    Answer = new List<string> { "Matthias" },
                    WrongAnswers = null,
                    Passage = "Acts 1:23-26",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 229,
                    Question = "About how many people waited in Jerusalem for the coming of the Holy Spirit?",
                    Answer = new List<string> { "120" },
                    WrongAnswers = null,
                    Passage = "Acts 1:12-15",
                    Type = "Number"
                },
                new QuestionInfo {
                    Number = 230,
                    Question = "What gift of God was given to the Church on the Day of Pentecost?",
                    Answer = new List<string> { "The gift of the Holy Spirit" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "The gift of the Bible" },
                        new List<string> { "The gift of dance" },
                        new List<string> { "The gift of healing" },
                        new List<string> { "The gift of knowledge" },
                    },
                    Passage = "Acts 2:1-4",
                    Type = null
                },
                new QuestionInfo {
                    Number = 231,
                    Question = "What Old Testament prophet foretold the outpouring of the Holy Spirit?",
                    Answer = new List<string> { "Joel" },
                    WrongAnswers = null,
                    Passage = "Acts 2:16",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 232,
                    Question = "About how many people were saved as a result of Peter's sermon on the Day of Pentecost?",
                    Answer = new List<string> { "3,000" },
                    WrongAnswers = null,
                    Passage = "Acts 2:41",
                    Type = "Number"
                },
                new QuestionInfo {
                    Number = 233,
                    Question = "What did Peter say to the lame man at the temple gate?",
                    Answer = new List<string> { "Acts 3:6 \"I don't have any silver or gold for you. But I'll give you what I have. In the name of Jesus Christ the Nazarene, get up and walk!\"" },
                    WrongAnswers = null,
                    Passage = "Acts 3:6",
                    Type = "DirectBibleQuote"
                },
                new QuestionInfo {
                    Number = 234,
                    Question = "What was the sin of Ananias and Sapphira?",
                    Answer = new List<string> { "They lied to the Holy Spirit." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "They lied to Saul." },
                        new List<string> { "They did not give up all their possessions." },
                        new List<string> { "They did not leave their home." },
                    },
                    Passage = "Acts 5:3",
                    Type = null
                },
                new QuestionInfo {
                    Number = 235,
                    Question = "Why did the apostles rejoice after being beaten for preaching the gospel?",
                    Answer = new List<string> { "Because they were counted worthy to suffer disgrace for the name of Jesus" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Because the beatings would stop" },
                        new List<string> { "Because Jesus would return to Earth someday" },
                        new List<string> { "Because the people would see their suffering and lament" },
                    },
                    Passage = "Acts 5:40-42",
                    Type = null
                },
                new QuestionInfo {
                    Number = 236,
                    Question = "Who was the first person to be martyred for being a Christian?",
                    Answer = new List<string> { "Stephen" },
                    WrongAnswers = null,
                    Passage = "Acts 7:59",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 237,
                    Question = "According to church history, who was the only one of the twelve apostles not martyred for his faith in the risen Christ?",
                    Answer = new List<string> { "John" },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 238,
                    Question = "Why did Saul of Tarsus go to Damascus?",
                    Answer = new List<string> { "To arrest Christians" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "To collect taxes" },
                        new List<string> { "To get a name change" },
                        new List<string> { "To free Christians" },
                    },
                    Passage = "Acts 9:1-2",
                    Type = null
                },
                new QuestionInfo {
                    Number = 239,
                    Question = "What happened to Saul of Tarsus near Damascus?",
                    Answer = new List<string> { "Jesus appeared to him in a light from heaven, and Saul accepted Him as Lord." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "A donkey spoke to him." },
                        new List<string> { "He was robbed and beaten by theives." },
                        new List<string> { "He found a silver coin." },
                    },
                    Passage = "Acts 9:3-9",
                    Type = null
                },
                new QuestionInfo {
                    Number = 240,
                    Question = "Who was raised from the dead in answer to Peter's prayer?",
                    Answer = new List<string> { "Tabitha [Dorcas]" },
                    WrongAnswers = null,
                    Passage = "Acts 9:36-41",
                    Type = "Woman"
                },
                new QuestionInfo {
                    Number = 241,
                    Question = "Who was the Roman officer who sent for Peter to come and preach to him?",
                    Answer = new List<string> { "Cornelius" },
                    WrongAnswers = null,
                    Passage = "Acts 10:1",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 242,
                    Question = "What happened while Peter was preaching at Cornelius's house?",
                    Answer = new List<string> { "The Holy Spirit fell upon all who were listening to the message." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "The Romans arrested everyone." },
                        new List<string> { "An earthquake happened." },
                        new List<string> { "A dove pearched at the window." },
                    },
                    Passage = "Acts 10:44-48",
                    Type = null
                },
                new QuestionInfo {
                    Number = 243,
                    Question = "In what city were Jesus' followers first called \"Christians\"?",
                    Answer = new List<string> { "Antioch" },
                    WrongAnswers = null,
                    Passage = "Acts 11:26",
                    Type = "Place"
                },
                new QuestionInfo {
                    Number = 244,
                    Question = "How did Peter escape from prison the night before Herod planned to kill him?",
                    Answer = new List<string> { "An angel opened the prison for him." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "The door was left unlocked." },
                        new List<string> { "Peter got the key from the guard." },
                        new List<string> { "Peter bribed the guard." },
                    },
                    Passage = "Acts 12:6-11",
                    Type = null
                },
                new QuestionInfo {
                    Number = 245,
                    Question = "Who helped Paul on his first missionary journey?",
                    Answer = new List<string> { "Barnabas" },
                    WrongAnswers = null,
                    Passage = "Acts 13:1-4",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 246,
                    Question = "What happened to Paul at Lystra after the people had thought he was a god?",
                    Answer = new List<string> { "He was stoned and left for dead, but God healed him." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "He was made ruler of the kinddom." },
                        new List<string> { "The people made a temple to him." },
                        new List<string> { "Paul healed the sick." },
                    },
                    Passage = "Acts 14:11-20",
                    Type = null
                },
                new QuestionInfo {
                    Number = 247,
                    Question = "How did Paul know he was supposed to preach in Macedonia?",
                    Answer = new List<string> { "God showed him a vision of a man from Macedonia calling for help." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "God showed him a map in a dream." },
                        new List<string> { "A man from Macedonia spoke to Paul." },
                        new List<string> { "Paul followed a star to Macedonia." },
                    },
                    Passage = "Acts 16:9-10",
                    Type = null
                },
                new QuestionInfo {
                    Number = 248,
                    Question = "Who were Paul's chief helpers on his second missionary journey?",
                    Answer = new List<string> { "Silas and Timothy" },
                    WrongAnswers = null,
                    Passage = "Acts 15:40; 16:1-4",
                    Type = "TwoPersons"
                },
                new QuestionInfo {
                    Number = 249,
                    Question = "Who wrote the Book of Acts?",
                    Answer = new List<string> { "Luke" },
                    WrongAnswers = null,
                    Passage = "Luke 1:3; Acts 1:1",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 250,
                    Question = "What was the occupation of Luke?",
                    Answer = new List<string> { "Doctor" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Priest" },
                        new List<string> { "Tax Collector" },
                        new List<string> { "Carpenter" },
                        new List<string> { "YouTuber" },
                    },
                    Passage = "Colossians 4:14",
                    Type = null
                },
                new QuestionInfo {
                    Number = 251,
                    Question = "What did Paul tell the Philippian jailer to do in order to be saved?",
                    Answer = new List<string> { "Acts 16:31 \"Believe in the Lord Jesus and you will be saved, along with everyone in your household.\"" },
                    WrongAnswers = null,
                    Passage = "Acts 16:31",
                    Type = "DirectBibleQuote"
                },
                new QuestionInfo {
                    Number = 252,
                    Question = "Who were the tentmakers who assisted Paul at Corinth?",
                    Answer = new List<string> { "Aquila and Priscilla" },
                    WrongAnswers = null,
                    Passage = "Acts 18:1-3",
                    Type = "TwoPersons"
                },
                new QuestionInfo {
                    Number = 253,
                    Question = "What did the people of Ephesus do with their books of witchcraft to show they had turned to God?",
                    Answer = new List<string> { "They burned them." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "They buried them." },
                        new List<string> { "They sent them away." },
                        new List<string> { "They recyled them." },
                        new List<string> { "They read them." },
                    },
                    Passage = "Acts 19:18-19",
                    Type = null
                },
                new QuestionInfo {
                    Number = 254,
                    Question = "In Ephesians, what command does Paul give to the children?",
                    Answer = new List<string> { "Children, obey your parents." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Parents, obey your children." },
                        new List<string> { "Children, obey your older siblings." },
                        new List<string> { "Children, obey your elders." },
                        new List<string> { "Children, do whatever you want." },
                    },
                    Passage = "Ephesians 6:1",
                    Type = null
                },
                new QuestionInfo {
                    Number = 255,
                    Question = "Does God treat all people alike?",
                    Answer = new List<string> { "Yes, all people are equal before God" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "No, people are not equal before God" },
                        new List<string> { "No, only Christians are equal before God" },
                        new List<string> { "No" },
                    },
                    Passage = "2 Chronicles 19:7; Romans 2:11",
                    Type = null
                },
                new QuestionInfo {
                    Number = 256,
                    Question = "Why did God give the Law?",
                    Answer = new List<string> { "To show us how sinful we are" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "To show how good we are" },
                        new List<string> { "Because he can" },
                        new List<string> { "Because people needed rules" },
                    },
                    Passage = "Romans 3:20",
                    Type = null
                },
                new QuestionInfo {
                    Number = 257,
                    Question = "What is the penalty of sin?",
                    Answer = new List<string> { "Romans 6:23 \"For the wages of sin is death, but the free gift of God is eternal life through Christ Jesus our Lord.\"" },
                    WrongAnswers = null,
                    Passage = "Romans 6:23",
                    Type = "DirectBibleQuote"
                },
                new QuestionInfo {
                    Number = 258,
                    Question = "Why did Jesus die on the Cross?",
                    Answer = new List<string> { "He died for our sins." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "He died to conquer the Romans." },
                        new List<string> { "He died for the Jews." },
                        new List<string> { "He died for nothing." },
                    },
                    Passage = "1 Corinthians 15:3",
                    Type = null
                },
                new QuestionInfo {
                    Number = 259,
                    Question = "Why should we wear all of the armor of God?",
                    Answer = new List<string> { "So that we can resist the attacks of the devil" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "So we can protect ourselved from non-Christians" },
                        new List<string> { "So we can attack our enemies" },
                        new List<string> { "So we can lead others to Jesus" },
                    },
                    Passage = "Ephesians 6:11-13",
                    Type = null
                },
                new QuestionInfo {
                    Number = 260,
                    Question = "In the Christian's armor, what is the belt?",
                    Answer = new List<string> { "Truth" },
                    WrongAnswers = null,
                    Passage = "Ephesians 6:14",
                    Type = "ChristiansArmor"
                },
                new QuestionInfo {
                    Number = 261,
                    Question = "In the Christian's armor, what is the body armor?",
                    Answer = new List<string> { "God's righteousness" },
                    WrongAnswers = null,
                    Passage = "Ephesians 6:14",
                    Type = "ChristiansArmor"
                },
                new QuestionInfo {
                    Number = 262,
                    Question = "In the Christian's armor, what is worn on the feet?",
                    Answer = new List<string> { "The peace that comes from the good news so that you will be fully prepared" },
                    WrongAnswers = null,
                    Passage = "Ephesians 6:15",
                    Type = "ChristiansArmor"
                },
                new QuestionInfo {
                    Number = 263,
                    Question = "In the Christian's armor, what is the shield?",
                    Answer = new List<string> { "Faith" },
                    WrongAnswers = null,
                    Passage = "Ephesians 6:16",
                    Type = "ChristiansArmor"
                },
                new QuestionInfo {
                    Number = 264,
                    Question = "In the Christian's armor, what is the helmet?",
                    Answer = new List<string> { "Salvation" },
                    WrongAnswers = null,
                    Passage = "Ephesians 6:17",
                    Type = "ChristiansArmor"
                },
                new QuestionInfo {
                    Number = 265,
                    Question = "What should Christians use to protect themselves from the devil's fiery arrows?",
                    Answer = new List<string> { "The shield of faith" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "The shield of truth" },
                        new List<string> { "The helmet of salvation" },
                        new List<string> { "The gauntlets of justice" },
                    },
                    Passage = "Ephesians 6:16",
                    Type = null
                },
                new QuestionInfo {
                    Number = 266,
                    Question = "What is the Spirit's sword?",
                    Answer = new List<string> { "The Word of God" },
                    WrongAnswers = null,
                    Passage = "Ephesians 6:17",
                    Type = "ChristiansArmor"
                },
                new QuestionInfo {
                    Number = 267,
                    Question = "When should Christians rejoice?",
                    Answer = new List<string> { "Always" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Sometimes" },
                        new List<string> { "Never" },
                        new List<string> { "Only when good things happen" },
                        new List<string> { "Only when bad things happen" },
                    },
                    Passage = "Philippians 4:4",
                    Type = null
                },
                new QuestionInfo {
                    Number = 268,
                    Question = "To what young pastor did Paul write two letters which are books of the Bible?",
                    Answer = new List<string> { "Timothy" },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 269,
                    Question = "Who was the slave Paul won to the Lord while in prison?",
                    Answer = new List<string> { "Onesimus" },
                    WrongAnswers = null,
                    Passage = "Philemon 10-13",
                    Type = "Man"
                },
                new QuestionInfo {
                    Number = 270,
                    Question = "Why do we love God?",
                    Answer = new List<string> { "Because He first loved us" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Because we loved God first" },
                        new List<string> { "Because of Adam and Eve" },
                        new List<string> { "Because God gave us rainbows" },
                        new List<string> { "Because God created us" },
                    },
                    Passage = "1 John 4:8-19",
                    Type = null
                },
                new QuestionInfo {
                    Number = 271,
                    Question = "What happened to John on the isle of Patmos?",
                    Answer = new List<string> { "God showed him what was going to happen in the last days." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "God showed him his future." },
                        new List<string> { "God rescued him from the island." },
                        new List<string> { "God gave him food." },
                        new List<string> { "God told him the secret of life." },
                    },
                    Passage = "Revelation 4:1",
                    Type = null
                },
                new QuestionInfo {
                    Number = 272,
                    Question = "What is an apostle?",
                    Answer = new List<string> { "A special messenger sent by God." },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "TermDefinition"
                },
                new QuestionInfo {
                    Number = 273,
                    Question = "What is faith?",
                    Answer = new List<string> { "Belief and complete trust in God." },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "TermDefinition"
                },
                new QuestionInfo {
                    Number = 274,
                    Question = "What is doctrine?",
                    Answer = new List<string> { "Teaching from the Bible." },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "TermDefinition"
                },
                new QuestionInfo {
                    Number = 275,
                    Question = "What is sin?",
                    Answer = new List<string> { "Refusing to do God's will as revealed by His Word and His Spirit." },
                    WrongAnswers = null,
                    Passage = "James 4:17; 1 John 3:4",
                    Type = "TermDefinition"
                },
                new QuestionInfo {
                    Number = 276,
                    Question = "What is grace?",
                    Answer = new List<string> { "God offers us His love and forgiveness as a gift and not because we have earned it or deserve it." },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "TermDefinition"
                },
                new QuestionInfo {
                    Number = 277,
                    Question = "What is redemption?",
                    Answer = new List<string> { "The price Jesus paid for our salvation." },
                    WrongAnswers = null,
                    Passage = "Ephesians 1:7; Colossians 1:13-14",
                    Type = "TermDefinition"
                },
                new QuestionInfo {
                    Number = 278,
                    Question = "What is death?",
                    Answer = new List<string> { "The separation of the body and the soul." },
                    WrongAnswers = null,
                    Passage = "Matthew 10:28",
                    Type = "TermDefinition"
                },
                new QuestionInfo {
                    Number = 279,
                    Question = "What is a prophet?",
                    Answer = new List<string> { "A person whom God has chosen to speak for Him in a special way through the power of the Holy Spirit." },
                    WrongAnswers = null,
                    Passage = "Deuteronomy 18:28; Judges 4:4; 1 Samuel 19:20; Acts 2:17",
                    Type = "TermDefinition"
                },
                new QuestionInfo {
                    Number = 280,
                    Question = "Who are the angels?",
                    Answer = new List<string> { "Spiritual beings created by God" },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "Spiritual beings created before God" },
                        new List<string> { "Guardians of the Earth" },
                        new List<string> { "Earthly beings created by God" },
                        new List<string> { "A type of animal created by God" },
                    },
                    Passage = "Colossians 1:16; Hebrews 1:14",
                    Type = null
                },
                new QuestionInfo {
                    Number = 281,
                    Question = "What do we mean when we say that God is immutable?",
                    Answer = new List<string> { "God does not change. He is always the same." },
                    WrongAnswers = new List<List<string>> {
                        new List<string> { "God knows all. He is all knowing." },
                        new List<string> { "God is everywhere." },
                        new List<string> { "God cannot hear." },
                    },
                    Passage = "Malachi 3:6; James 1:17",
                    Type = null
                },
                new QuestionInfo {
                    Number = 282,
                    Question = "What is a disciple?",
                    Answer = new List<string> { "A learner [follower] of Jesus." },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "TermDefinition"
                },
                new QuestionInfo {
                    Number = 283,
                    Question = "What is prayer?",
                    Answer = new List<string> { "Talking with God." },
                    WrongAnswers = null,
                    Passage = null,
                    Type = "TermDefinition"
                },
                new QuestionInfo {
                    Number = 284,
                    Question = "What is praise?",
                    Answer = new List<string> { "Expressing our love to God for all He is and all that He has done." },
                    WrongAnswers = null,
                    Passage = "Psalm 30:4; 71:16",
                    Type = "TermDefinition"
                },
                new QuestionInfo {
                    Number = 285,
                    Question = "What is worship?",
                    Answer = new List<string> { "Exalting and adoring God for who He is." },
                    WrongAnswers = null,
                    Passage = "Psalm 29:2",
                    Type = "TermDefinition"
                },
                new QuestionInfo {
                    Number = 286,
                    Question = "What does \"repentance\" mean?",
                    Answer = new List<string> { "Having a change of mind, heart, and direction." },
                    WrongAnswers = null,
                    Passage = "Acts 17:30; 20:21",
                    Type = "TermDefinition"
                },
                new QuestionInfo {
                    Number = 287,
                    Question = "What is justification?",
                    Answer = new List<string> { "When we accept Jesus as our Savior, God accepts us as though we had not sinned." },
                    WrongAnswers = null,
                    Passage = "Romans 5:1",
                    Type = "TermDefinition"
                },
                new QuestionInfo {
                    Number = 288,
                    Question = "What is sanctification?",
                    Answer = new List<string> { "Being separated from sin and set apart to serve God." },
                    WrongAnswers = null,
                    Passage = "Romans 12:1-2; 1 Thessalonians 5:23; Hebrews 12:14",
                    Type = "TermDefinition"
                },
            };
        }

        public int GetMaxNumber()
        {
            return _data.Max(x => x.Number);
        }

        public IEnumerable<QuestionInfo> GetAll()
        {
            return _data;
        }

        public QuestionInfo GetByNumber(int number)
        {
            return _data.SingleOrDefault(x => x.Number == number);
        }

        public IEnumerable<QuestionInfo> GetByType(string type)
        {
            return _data.Where(x => x.Type == type);
        }
    }
}
