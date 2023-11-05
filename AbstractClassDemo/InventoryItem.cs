namespace AbstractClassDemo
{
    //Abstract classes are class you build upon(Base Clase, foundation)
    // you cant directly instantiate an abstract class
    public abstract class InventoryItem
    {

        public string productName { get; set; }
        public int QuantiryonHand { get; set; }
    }
}
