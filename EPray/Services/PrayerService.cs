using EPray.EntityFramework;
using EPray.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPray.Services
{
    public  class PrayerService
    {
        private PrayerContext _context;
        public PrayerService()
        {

        }
        public PrayerService(PrayerContext context)
        {
            _context = context;
        }

        public IEnumerable<PrayerModel> PopulatePrayerDB()
        {
            var prayers = new List<PrayerModel>
            {
                new PrayerModel
                {
                    Lyrics = "Lord, we are not ready to have a child right now. \n If it be your will, please let us not be pregnant now and instead get pregnant later.\n But if not, then please give us the grace to handle this massive change in our lives in welcoming this little person.",
                    Reason = PrayerReasonType.PREGNANCY_PREVENTION,
                    Religion = ReligionType.CHRISTIAN
                },

                new PrayerModel {
                    Lyrics = "I humbly pray that you look after those who are suffering from cancer.\n Please give them the strength and courage needed to overcome their tribulation.\n Lord, help me to be aware of and to never take for granted the health and gifts which you have blessed me with.",
                    Reason = PrayerReasonType.CANCER,
                    Religion = ReligionType.CHRISTIAN
                },

                new PrayerModel {
                Lyrics = "My Father, I thank you for your love and kindness towards me and my family in Jesus Name. \n My Father, I worship you for your protection and provision for me and my household in Jesus Name \n Oh Lord, I decree and declare that diabetes will never find a place to stay in my body system in Jesus Name",
                Reason = PrayerReasonType.DIABETIS,
                Religion = ReligionType.CHRISTIAN
                },



                new PrayerModel {
                    Lyrics = "Think, O' God, of our friend who is ill, whom we now commend to Your compassionate regard. that no healing is too hard if it be Your will.\n We therefore pray that You bless our friend with Your loving care, renew his/her strength,\n and heal what ails him/her in Your loving name.",
                    Reason = PrayerReasonType.GENERAL,
                    Religion = ReligionType.CHRISTIAN
                },


                new PrayerModel {
                    Lyrics = "Father, let the blood of Jesus. the fire and the living water of the God wash my system clean from satanic poison food, in Jesus name.",
                    Reason = PrayerReasonType.COLESTEROL,
                    Religion = ReligionType.CHRISTIAN
                },


                new PrayerModel {
                    Lyrics = "Lord, I thank You for this baby and I give my pregnancy to You, praying that throughout the whole time You will be there to comfort and encourage and strengthen each member of the family. I pray that You would place Your hand of blessing on this little human being that is being formed in my womb...",
                    Reason = PrayerReasonType.PREGNANCY,
                    Religion = ReligionType.CHRISTIAN
                },

                new PrayerModel
                {
                    Lyrics = "Father I pray blessings on this request and for the healing of this condition in Jesus name I pray.",
                    Reason = PrayerReasonType.HEMOROIDS,
                    Religion = ReligionType.CHRISTIAN
                },

                new PrayerModel
                {
                    Lyrics = "Lord Jesus Christ, I confess here and now that you are my Creator (John 1:3) and therefore the creator of my sexuality. I confess that you are also my Savior, that you have ransomed me with your blood (1 Corinthians 15:3, Matthew 20:28). I have been bought with the blood of Jesus Christ; my life and my body belong to God (1 Corinthians 6:19–20). Jesus, I present myself to you now to be made whole and holy in every way, including in my sexuality. You ask us to present our bodies to you as living sacrifices (Romans 12:1) and the parts of our bodies as instruments of righteousness (Romans 6:13). I do this now. I present my body, my sexuality and I present my sexual nature to you. I consecrate my sexuality to Jesus Christ.",
                    Reason = PrayerReasonType.POTENCY,
                    Religion = ReligionType.CHRISTIAN
                },

                new PrayerModel
                {
                    Lyrics = "Give them the courage and strength to fight another day and grant us the grace to use our pain to reach out with help and support. Dear Lord, we ask with all or our heart, please touch these special lives. Bless them with courage and hope, may all find solace in your loving embrace. Heal them in body, mind, and spirit.",
                    Reason = PrayerReasonType.CANCER,
                    Religion = ReligionType.MUSLIM
                },

                new PrayerModel
                {
                    Lyrics = "O Lord of the people, remove this pain and cure it, You are the one who cures and there is no one besides You who can cure, grant such a cure that no illness remains",
                    Reason = PrayerReasonType.POTENCY,
                    Religion = ReligionType.MUSLIM
                },

                new PrayerModel
                {
                    Lyrics = "If we are peaceful, If we are happy, We can smile and blossom like a flower. And everyone in our family, Our entire society, Will benefit From our peace.",
                    Reason = PrayerReasonType.GENERAL,
                    Religion = ReligionType.BUDIST
                },

                new PrayerModel
                {
                    Lyrics = "Enlightenment is like the moon reflected on the water. The moon does not get wet, nor is the water broken. Although its light is wide and great, The moon is reflected even in a puddle an inch wide. The whole moon and the entire sky Are reflected in one dewdrop on the grass.",
                    Reason = PrayerReasonType.GENERAL,
                    Religion = ReligionType.BUDIST
                },

                new PrayerModel
                {
                    Lyrics = "Glory be to the father and to the maker of creation. As it was, in the beginning, is now and ever shall be World without end.",
                    Reason = PrayerReasonType.GENERAL,
                    Religion = ReligionType.RASTAFARI
                },
            };
            return prayers;
            
        }

        public IEnumerable<PrayerModel> GetPrayersByReligion(ReligionType religion, PrayerContext context)
        {
            var prayers = from prayer in context.Prayers where prayer.Religion == religion select prayer;
            return prayers;
        }
    }
}
