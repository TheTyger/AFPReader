using System.Collections.Generic;
using AFP_Reader.Structured_Field_Definitions;

namespace AFP_Reader
{
    public class SFIData{
        public SFIData() {
        }
        
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
    }

    public static class SFILooksups
    {
        public static Dictionary<string, SFIData> StandardFieldInfo = new Dictionary<string, SFIData>
        {
            {"D3A088",  MediumFinishingControl.ConvertToSFIData()},
            {"D3A090",  TagLogicalElement.ConvertToSFIData()},
            {"D3A288",  MediumCopyCount.ConvertToSFIData()},
            {"D3A66B",  ObjectAreaDescriptor.ConvertToSFIData()},
            {"D3A67B",  ImageInputDescriptor.ConvertToSFIData()},

            {"D3A688",  MediumDescriptor.ConvertToSFIData()},
            {"D3A68D",  RecordDescriptor.ConvertToSFIData()},
            {"D3A68E",  XMLDescriptor.ConvertToSFIData()},
            {"D3A692",  ContainerDataDescriptor.ConvertToSFIData()},
            {"D3A69B",  PresentationTextDataDescriptor.ConvertToSFIData()},

            {"D3A6AF",  PageDescriptor.ConvertToSFIData()},
            {"D3A6BB",  GraphicsDataDescriptor.ConvertToSFIData()},
            {"D3A6C5",  FormEnvironmentGroupDescriptor.ConvertToSFIData()},
            {"D3A6E3",  DataMapTransmissionSubcaseDescriptor.ConvertToSFIData()},
            {"D3A6E7",  LineDescriptor.ConvertToSFIData()},

            {"D3A6EB",  BarCodeDataDescriptor.ConvertToSFIData()},
            {"D3A6FB",  ImageDataDescriptor.ConvertToSFIData()},
            {"D3A77B",  ImageOutputControl.ConvertToSFIData()},
            {"D3A788",  MediumModificationControl.ConvertToSFIData()},
            {"D3A79B",  ComposedTextControl.ConvertToSFIData()},

            {"D3A7AF",  PageModificationControl.ConvertToSFIData()},
            {"D3A7A8",  PresentationEnvironmentControl.ConvertToSFIData()},
            {"D3A7CA",  ConditionalProcessingControl.ConvertToSFIData()},
            {"D3A85F",  BeginPageSegment.ConvertToSFIData()},
            {"D3A87B",  BeginImageBlock.ConvertToSFIData()},

            {"D3A892",  BeginObjectContainer.ConvertToSFIData()},
            {"D3A89B",  BeginPresentationTextBlock.ConvertToSFIData()},
            {"D3A8A7",  BeginDocumentIndex.ConvertToSFIData()},
            {"D3A8A8",  BeginDocument.ConvertToSFIData()},
            {"D3A8AD",  BeginNamedPageGroup.ConvertToSFIData()},

            {"D3A8AF",  BeginPage.ConvertToSFIData()},
            {"D3A8BB",  BeginGraphicsObject.ConvertToSFIData()},
            {"D3A8C4",  BeginDocumentEnvironmentGroup.ConvertToSFIData()},
            {"D3A8C5",  BeginFormEnvironmentGroup.ConvertToSFIData()},
            {"D3A8C6",  BeginResourceGroup.ConvertToSFIData()},

            {"D3A8C7",  BeginObjectEnvironmentGroup.ConvertToSFIData()},
            {"D3A8C9",  BeginActiveEnvironmentGroup.ConvertToSFIData()},
            {"D3A8CA",  BeginDataMap.ConvertToSFIData()},
            {"D3A8CB",  BeginPageMap.ConvertToSFIData()},
            {"D3A8CC",  BeginMediumMap.ConvertToSFIData()},

            {"D3A8CD",  BeginFormMap.ConvertToSFIData()},
            {"D3A8CE",  BeginResource.ConvertToSFIData()},
            {"D3A8D9",  BeginResourceEnvironmentGroup.ConvertToSFIData()},
            {"D3A8DF",  BeginOverlay.ConvertToSFIData()},
            {"D3A8E3",  BeginDataMapTransmissionSubcase.ConvertToSFIData()},

            {"D3A8EB",  BeginBarCodeObject.ConvertToSFIData()},
            {"D3A8FB",  BeginImageObjectIO.ConvertToSFIData()},
            {"D3A95F",  EndPageSegment.ConvertToSFIData()},
            {"D3A97B",  EndIMImageObject.ConvertToSFIData()},
            {"D3A992", EndObjectContainer.ConvertToSFIData()},

            {"D3A99B",  EndPresentationTextObject.ConvertToSFIData()},
            {"D3A9A7",  EndDocumentIndex.ConvertToSFIData()},
            {"D3A9A8",  EndDocument.ConvertToSFIData()},
            {"D3A9AD",  EndNamedPageGroup.ConvertToSFIData()},
            {"D3A9AF",  EndPage.ConvertToSFIData()},

            {"D3A9BB",  EndGraphicsObject.ConvertToSFIData()},
            {"D3A9C4",  EndDocumentEnvironment.ConvertToSFIData()},
            {"D3A9C5",  EndFormEnvironmentGroup.ConvertToSFIData()},
            {"D3A9C6",  EndResourceGroup.ConvertToSFIData()},
            {"D3A9C7",  EndObjectEnvironmentGroup.ConvertToSFIData()},

            {"D3A9C9",  EndActiveEnvironmentGroup.ConvertToSFIData()},
            {"D3A9CA",  EndDataMap.ConvertToSFIData()},
            {"D3A9CB",  EndPageMap.ConvertToSFIData()},
            {"D3A9CC",  EndMediumMap.ConvertToSFIData()},
            {"D3A9CD",  EndFormMap.ConvertToSFIData()},

            {"D3A9CE",  EndResource.ConvertToSFIData()},
            {"D3A9D9",  EndResourceEnvironmentGroup.ConvertToSFIData()},
            {"D3A9DF",  EndOverlay.ConvertToSFIData()},
            {"D3A9E3",  EndDataMapTransmissionSubcase.ConvertToSFIData()},
            {"D3A9EB",  EndBarCodeObject.ConvertToSFIData()},

            {"D3A9FB",  EndImageObject.ConvertToSFIData()},
            {"D3AAE7",  LineDescriptorCount.ConvertToSFIData()},
            {"D3AAEC",  FixedDataSize.ConvertToSFIData()},
            {"D3AB88",  MapMediaType.ConvertToSFIData()},
            {"D3AB92",  MapContainerData.ConvertToSFIData()},

            {"D3ABAF",  MapPage.ConvertToSFIData()},
            {"D3ABBB",  MapGraphicsObject.ConvertToSFIData()},
            {"D3ABC3",  MapDataResource.ConvertToSFIData()},
            {"D3ABCA",  InvokeDataMap.ConvertToSFIData()},
            {"D3ABCC",  InvokeMediumMap.ConvertToSFIData()},

            {"D3ABD8",  MapPageOverlay.ConvertToSFIData()},
            {"D3ABEA",  MapSuppression.ConvertToSFIData()},
            {"D3ABEB",  MapBarCode.ConvertToSFIData()},
            {"D3ABFB",  MapImageObject.ConvertToSFIData()},
            {"D3AC6B",  ObjectAreaPosition.ConvertToSFIData()},

            {"D3AC7B",  ImageCellPosition.ConvertToSFIData()},
            {"D3ACAF",  PagePosition.ConvertToSFIData()},
            {"D3ADC3",  PreprocessPresentationObject.ConvertToSFIData()},
            {"D3AF5F",  InculdePageSegment.ConvertToSFIData()},
            {"D3AFAF",  IncludePage.ConvertToSFIData()},

            {"D3AFC3",  IncludeObject.ConvertToSFIData()},
            {"D3AFD8",  IncludePageOverlay.ConvertToSFIData()},
            {"D3B15F",  MapPageSegment.ConvertToSFIData()},
            {"D3B18A",  MapCodedFont.ConvertToSFIData()},
            {"D3B19B",  PresentationTextDescriptor.ConvertToSFIData()},

            {"D3B1AF",  PagePosition2.ConvertToSFIData()},
            {"D3B1DF",  MapMediumOverlay.ConvertToSFIData()},
            {"D3B288",  PresentationFidelityControl.ConvertToSFIData()},
            {"D3B2A7",  IndexElement.ConvertToSFIData()},
            {"D3B490",  LinkLogicalElement.ConvertToSFIData()},

            {"D3EE7B",  ImageRasterData.ConvertToSFIData()},
            {"D3EE92",  ObjectContainerData.ConvertToSFIData()},
            {"D3EEBB",  GraphicsData.ConvertToSFIData()},
            {"D3EE9B",  PresentationTextData.ConvertToSFIData()},
            {"D3EEEB",  BarCodeData.ConvertToSFIData()},

            {"D3EEEC",  FixedDataText.ConvertToSFIData()},
            {"D3EEEE",  NoOperation.ConvertToSFIData()},
            {"D3EEFB",  ImagePictureData.ConvertToSFIData()}

        };
    }
}
