namespace DemoApp.ViewModel
{
    public class CustomerDto
    {

        public int Id { get; set; }      // for update
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Number { get; set; } = null!;
    }
}
