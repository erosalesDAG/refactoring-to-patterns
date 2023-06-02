namespace RefactoringToPatterns.CreationMethods
{
    public class ProductPackage
    {
        private readonly string _internetLabel;
        private readonly int? _telephoneNumber;
        private readonly string[] _tvChannels;

        public ProductPackage(string internetLabel)
        {
            _internetLabel = internetLabel;
        }

        public ProductPackage(string internetLabel, int telephoneNumber)
        {
            _internetLabel = internetLabel;
            _telephoneNumber = telephoneNumber;
        }

        public ProductPackage(string internetLabel, string[] tvChannels)
        {
            _internetLabel = internetLabel;
            _tvChannels = tvChannels;
        }

        public ProductPackage(string internetLabel, int telephoneNumber, string[] tvChannels)
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
            return new ProductPackage(internetLabel);
        }

        public static ProductPackage InternetAndVoipProduct(string internetLabel, int telephoneNumber)
        {
            return new ProductPackage(internetLabel, telephoneNumber);
        }

        public static ProductPackage InternetAndTvProduct(string internetLabel, string[] tvChannels)
        {
            return new ProductPackage(internetLabel, tvChannels);
        }

        public static ProductPackage FullComboProduct(string internetLabel, int telephoneNumber, string[] tvChannels)
        {
            return new ProductPackage(internetLabel, telephoneNumber, tvChannels);
        }
    }
}