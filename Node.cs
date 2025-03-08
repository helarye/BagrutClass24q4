// See https://aka.ms/new-console-template for more information
namespace BagrutClass24q4
{
    public class Node<T>
    {
        private T value;//ערך החוליה
        private Node<T> next;//מצביע על החוליה הבאה
                             //פונקציה בונה שיוצרת חוליה עם ערך ללא חוליות אחריה
        public Node(T value)
        {
            this.value = value;
            next = null;
        }
        public Node(T value, Node<T> next)
        {
            this.value = value;
            this.next = next;
        }

        public T GetValue()
        {
            return value;
        }

        public Node<T> GetNext()
        {
            return next;
        }
        //הפונק' מחזירה אמת אם לחוליה הנוכחית יש חוליה עוקבת
        public bool HasNext()
        {
            return next != null;
        }
        //פונק' הקובעת את ערך החוליה הנוכחית
        public void SetValue(T value)
        {
            this.value = value;
        }
        //פונק' הקובעת את החוליה העוקבת של החוליה הנוכחית
        public void SetNext(Node<T> next)
        {
            this.next = next;
        }
        //פונקציה המכינה מחרוזת מכל החוליות המקושרות החל מן החוליה
        //הנתונה
        public override string ToString()
        {
            string str2return = "";
            if (next == null)
                str2return = value + "-->null";
            else
                str2return = value + "-->" + next;
            return str2return;
        }
    }
}