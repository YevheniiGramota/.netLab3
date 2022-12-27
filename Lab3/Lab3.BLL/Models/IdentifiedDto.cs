using Lab3.BLL.Models;

namespace Lab3.DAL.Entities;

public abstract class IdentifiedDto<T> : BaseDto
{
    public T Id { get; set; } = default!;
}

public abstract class IdentifiedDto : IdentifiedDto<long>
{

}