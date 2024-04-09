using MyLinkedList;

var MyList = new MyLinkedList<int>();

MyList.Add(1);
MyList.Add(22);
MyList.Add(26);

MyList.Delete(1);
MyList.AppendHead(5);

foreach (var item in MyList)
{
    Console.WriteLine(item);
}

