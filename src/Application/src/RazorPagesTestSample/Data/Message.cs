using System.ComponentModel.DataAnnotations;

namespace RazorPagesTestSample.Data
{
    #region snippet1
    public class Message
    {
        public int Id { get; set; }

        /// <summary>
        /// /// Gets or sets the text of the message.
        /// </summary>
        /// <remarks>
        /// This property is required and must not exceed 200 characters.
        /// If the limit is exceeded, an error message will be displayed.
        /// </remarks>
        /// /// /// /// /// /// [Required]
        [DataType(DataType.Text)]
        [StringLength(200, ErrorMessage = "There's a 200 character limit on messages. Please shorten your message.")]
        public string Text { get; set; }
    }
    #endregion
}
