public class Video{
    private string _author;
    private string _title;
    private int _length;
    List<Comment> _commentList;
    
    public Video(string author, string title, int length, List<Comment> list){
        _author = author;
        _title = title;
        _length = length;
        _commentList = list;
    }

    public string GetAuthor(){
        return _author;
    }
    public string GetTitle(){
        return _title;
    }
    public int GetLength(){
        return _length;
    }
    public void Display(){
        Console.WriteLine($"Video Title: {_title}\nAuthor: {_author} - Length: {_length} seconds"+
        $"\nComments:{_commentList.Count}");
    }
    public void DisplayComments(){
        Console.WriteLine("Comments ---");
        for(int i = 0; i < _commentList.Count; i++){
            Console.WriteLine(_commentList[i].GetComment());
        }
    }
    public int CommentsCount(){
        return _commentList.Count;
    }

}