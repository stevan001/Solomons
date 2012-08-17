using ProdigyProducts.BLL.Domain;

namespace ProdigyProducts.BLL.Adapters
{
    public class ProductTypeAttributeAdapter:IAdapter<Data.ProductTypeAttribute,Domain.ProductTypeAttribute>
    {
        public ProductTypeAttribute ConvertToDomainObject(Data.ProductTypeAttribute dataObject)
        {
            Domain.ProductTypeAttribute productTypeAttribute=new ProductTypeAttribute();
            productTypeAttribute.AttributeId = dataObject.attribute_id;
            productTypeAttribute.AttributeName = dataObject.attribute_name;
            productTypeAttribute.AttributeDataType = dataObject.attribute_data_types;
            productTypeAttribute.CategoryId = dataObject.category_id;
            return productTypeAttribute; 

        }

        public Data.ProductTypeAttribute ConvertToDataObject(ProductTypeAttribute domainObject)
        {
            Data.ProductTypeAttribute productTypeAttribute=new Data.ProductTypeAttribute();
            productTypeAttribute.attribute_id = domainObject.AttributeId;
            productTypeAttribute.attribute_name = domainObject.AttributeName;
            productTypeAttribute.attribute_data_types = domainObject.AttributeDataType;
            productTypeAttribute.category_id = domainObject.CategoryId;
            return productTypeAttribute;
        }

        public void UpdateDataObject(ProductTypeAttribute domainObject, ref Data.ProductTypeAttribute dataObject)
        {
            dataObject.attribute_data_types = domainObject.AttributeDataType;
            dataObject.attribute_name = domainObject.AttributeName;
        }
    }
}
