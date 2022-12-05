namespace SubscriptionForm.Data.Entities
{
    public partial class Subscriber
    {
        public Subscriber(string Name, string Email, string? AdditionalDetails)
        {
            #region Generated Constructor
            this.Name = Name;
            this.Email = Email;
            this.AdditionalDetails = AdditionalDetails;
            #endregion
        }

        #region Generated Properties
        public Guid Id = Guid.NewGuid();

        public string Name { get; set; }

        public string Email { get; set; }

        public string? AdditionalDetails { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
