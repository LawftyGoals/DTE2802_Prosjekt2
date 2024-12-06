namespace CMSAPI_Frontend.Data.Models;

class FolderDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int? ParentFolderId { get; set; }

}
class CreateFolderDto
{
    public string Name { get; set; } = null!;
    public int ParentFolderId { get; set; }

}

public class DocumentDto
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public string? ContentType { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? IdentityUserId { get; set; }
    public int? FolderId { get; set; }
    public string? FolderName { get; set; }
}

class NavigatableFolderDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public FolderDto? ParentFolder { get; set; }
    public List<DocumentDto> Documents { get; set; } = null!;
    public string Url { get; set; } = null!;

}
