
public class Customer
{
    public Customer(int id, string name)
    {
        ID = id;
        Name = name;
    }

    private int m_id;

    public int ID
    {
        get { return m_id; }
        set { m_id = value; }
    }

    private string m_name;

    public string Name
    {
        get { return m_name; }
        set { m_name = value; }
    }
}