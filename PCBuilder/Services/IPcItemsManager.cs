using PCBuilder.Model;

namespace PCBuilder.Services;

public interface IPcItemsManager
{
    public IEnumerable<TPcItem> GetPcItems<TPcItem>(string pcItemsFilePath) where TPcItem : PcItem;
}