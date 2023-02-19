using System.Reactive.Linq;
using System.Reactive.Subjects;
using GraphQL.Web.Models.Book;
using GraphQL.Web.Models.Book.Subscription;

namespace GraphQL.Web.Services;

public class BookEventService : IBookEventService
{
    private readonly ISubject<BookEvent> _events = new ReplaySubject<BookEvent>();

    public void BookChanged(Book book)
    {
        var bookEvent = new BookEvent
        {
            Book = book,
            Timestamp = DateTime.UtcNow
        };
        _events.OnNext(bookEvent);
    }
        
    public IObservable<BookEvent> OnUpdate()
    {
        return _events.AsObservable();
    }
}

public interface IBookEventService
{
    void BookChanged(Book book);
    IObservable<BookEvent> OnUpdate();
}