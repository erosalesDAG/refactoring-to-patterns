namespace RefactoringToPatterns.CreationMethods
{
    public class ProductPackage
    {
        private readonly string _internetLabel;
        private readonly int? _telephoneNumber;
        private readonly string[] _tvChannels;

        private ProductPackage(string internetLabel, int? telephoneNumber, string[] tvChannels)
        {
            _internetLabel = internetLabel;
            _telephoneNumber = telephoneNumber;
            _tvChannels = tvChannels;
        }

        public bool HasInternet()
        {
            return _internetLabel != null;
        }


        public bool HasVOIP()
        {
            return _telephoneNumber != null;
        }

        public bool HasTv()
        {
            return _tvChannels != null;
        }

        public static ProductPackage InternetProduct(string internetLabel)
        {
            return new ProductPackage(internetLabel, null, null);
        }

        public static ProductPackage InternetAndVoipProduct(string internetLabel, int telephoneNumber)
        {
            return new ProductPackage(internetLabel, telephoneNumber, null);
        }

        public static ProductPackage InternetAndTvProduct(string internetLabel, string[] tvChannels)
        {
            return new ProductPackage(internetLabel, null, tvChannels);
        }

        public static ProductPackage FullComboProduct(string internetLabel, int telephoneNumber, string[] tvChannels)
        {
            return new ProductPackage(internetLabel, telephoneNumber, tvChannels);
        }
    }
}