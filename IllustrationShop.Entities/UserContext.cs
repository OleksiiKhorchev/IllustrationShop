namespace IllustrationShop.Entities
{
    public class UserContext
    {
        public static User Current
        {
            get
            {
                if (_current != null)
                    return _current;

                return null; // !TODO!
            }
        }

        private static User _current;
    }
}
