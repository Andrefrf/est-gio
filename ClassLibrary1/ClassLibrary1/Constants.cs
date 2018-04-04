using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcarConstants
{
    public class IcarConstants
    {
        //box block names
        const int ICAR_TWAIN_DEVICE = 4;
        const int ICAR_READ_FILE_DEvIcE = 5;
        const int ICAR_HP_PHOTO_SCAN_1200_DEVICE = 14;
        const int ICAR_ICARBOX_240_B_DEVICE = 16;
        const int ICAR_BANCOR_IBM_K2S_DEVICE = 17;
        const int ICAR_VIRTUAL_FOLDER_DEVICE = 18;
        const int ICAR_ICARBOX_250_DEVICE = 20;
        const int ICAR_ICARBOX_250_VIU_DEVICES = 21;
        const int ICAR_ICARBOX_260_DEVICE = 22;
        const int ICAR_ICARBOX_260_VIU_DEVICE = 23;
        const int ICAR_ICARBOX_IDBOX_DEVICE = 24;
        const int ICAR_ICARBOX_IDBOX_VIU_DEVICE = 25;
        const int ICAR_ICARBOX_IDBOX_E_DEVICE = 26;
        const int ICAR_ICARBOX_IDBOX_E_VIU_DEVICE = 27;

        public int getBoxTwain()
        {
            return ICAR_TWAIN_DEVICE;
        }

        public int getBoxHP()
        {
            return ICAR_HP_PHOTO_SCAN_1200_DEVICE;
        }

        public int getBoxIcar240()
        {
            return ICAR_ICARBOX_240_B_DEVICE;
        }

        public int getBoxIbm()
        {
            return ICAR_BANCOR_IBM_K2S_DEVICE;
        }

        public int getBoxvirtual()
        {
            return ICAR_VIRTUAL_FOLDER_DEVICE;
        }

        public int getBox250Viu()
        {
            return ICAR_ICARBOX_250_VIU_DEVICES;
        }

        public int getBox250()
        {
            return ICAR_ICARBOX_250_DEVICE;
        }

        public int getBox260()
        {
            return ICAR_ICARBOX_260_DEVICE;
        }

        public int getBox260viu()
        {
            return ICAR_ICARBOX_260_VIU_DEVICE;
        }

        public int getIDBox()
        {
            return ICAR_ICARBOX_IDBOX_DEVICE;
        }

        public int getIdBoxviu()
        {
            return ICAR_ICARBOX_IDBOX_VIU_DEVICE;
        }

        public int getIdBoxE()
        {
            return ICAR_ICARBOX_IDBOX_E_DEVICE;
        }

        public int getIdBoxEviu()
        {
            return ICAR_ICARBOX_IDBOX_E_VIU_DEVICE;
        }


        //RFID setup
        const int ICAR_RFID_NO_DEVICE = 0;
        const int ICAR_RFID_PCSC_DEVICE = 1;
        const int ICAR_RFID_ASK_DEVICE = 2;
        const int ICAR_RFID_IDBOX_DEVICE = 3;

        public int getRFIDNoDev()
        {
            return ICAR_RFID_NO_DEVICE;
        }

        public int getRFIDPcsc()
        {
            return ICAR_RFID_PCSC_DEVICE;
        }

        public int getRFIDAsk()
        {
            return ICAR_RFID_ASK_DEVICE;
        }

        public int getRFIDbox()
        {
            return ICAR_RFID_IDBOX_DEVICE;
        }

        //card scanner setup
        const int ICAR_SC_NO_DEVICE = 0;
        const int ICAR_SC_IDBOX_DEVICE = 1;

        public int getSCdevice()
        {
            return ICAR_SC_NO_DEVICE;
        }

        public int getSCbox()
        {
            return ICAR_SC_IDBOX_DEVICE;
        }

        //document integration
        const int ICAR_NO_AUTO_INFO_INTEGRATION = 0;
        const int ICAR_AUTO_INFO_INTEGRATION_HOR_TILTING = 1;
        const int ICAR_AUTO_INFO_INTEGRATION_VER_TILTING = 2;
        const int ICAR_AUTO_INFO_NO_IMAGE_INTEGRATION = 5;

        public int getNoAutoInfo()
        {
            return ICAR_NO_AUTO_INFO_INTEGRATION;
        }

        public int getAutoInfoHor()
        {
            return ICAR_AUTO_INFO_INTEGRATION_HOR_TILTING;
        }

        public int getAutoInfoVer()
        {
            return ICAR_AUTO_INFO_INTEGRATION_VER_TILTING;
        }

        public int getAutoInfoNoImg()
        {
            return ICAR_AUTO_INFO_NO_IMAGE_INTEGRATION;
        }

        //tilting config
        const int ICAR_HORIZONTAL_TILTING = 0;
        const int ICAR_VERTICAL_TILTING = 1;

        public int getVertTilt()
        {
            return ICAR_VERTICAL_TILTING;
        }

        public int getHorizonTilt()
        {
            return ICAR_HORIZONTAL_TILTING;
        }

        //processing proprety
        const int ICAR_CFG_AUTOIMAGEMERGING = 0;
        const int ICAR_CFG_DATEFORMAT = 1;
        const int ICAR_CFG_UPPERCASE = 2;
        const int ICAR_CFG_REMOVEACCENTS = 3;
        const int ICAR_CFG_PROCESSMODE = 4;

        public int getImageMerging()
        {
            return ICAR_CFG_AUTOIMAGEMERGING;
        }

        public int getDateFormat()
        {
            return ICAR_CFG_DATEFORMAT;
        }

        public int getUpperCase()
        {
            return ICAR_CFG_UPPERCASE;
        }

        public int getRemoveAccents()
        {
            return ICAR_CFG_REMOVEACCENTS;
        }

        public int getProcessMode()
        {
            return ICAR_CFG_PROCESSMODE;
        }

        //images output proprety
        const int ICAR_OUTPUT_DOCIMAGES = 5;
        const int ICAR_OUTPUT_PHOTOIMAGES = 6;
        const int ICAR_OUTPUT_SIGNATUREIMG = 7;
        const int ICAR_OUTPUT_FINGERPRINTIMAGES = 8;
        const int ICAR_OUTPUT_DIGITALCOPYIMG = 9;

        public int getDocImageImg()
        {
            return ICAR_OUTPUT_DOCIMAGES;
        }

        public int getPhotoImageImg()
        {
            return ICAR_OUTPUT_PHOTOIMAGES;
        }

        public int getSignatureImg()
        {
            return ICAR_OUTPUT_SIGNATUREIMG;
        }

        public int getFingerPrintImg()
        {
            return ICAR_OUTPUT_FINGERPRINTIMAGES;
        }

        public int getDigiCopyImg()
        {
            return ICAR_OUTPUT_DIGITALCOPYIMG;
        }

        //color proprety
        const int ICAR_CFG_COLORMODE_DOCIMG = 10;
        const int ICAR_CFG_COLORMODE_PHOTOIMG = 11;
        const int ICAR_CFG_COLORMODE_SIGNATUREIMG = 12;
        const int ICAR_CFG_COLORMODE_FINGERPRINT = 13;
        const int ICAR_CFG_COLORMODE_DIGITALCOPYIMG = 14;

        public int getColorDocIMG()
        {
            return ICAR_CFG_COLORMODE_DOCIMG;
        }

        public int getColorPhotoImg()
        {
            return ICAR_CFG_COLORMODE_PHOTOIMG;
        }

        public int getColorSigImg()
        {
            return ICAR_CFG_COLORMODE_SIGNATUREIMG;
        }

        public int getColorFingerPrintImg()
        {
            return ICAR_CFG_COLORMODE_FINGERPRINT;
        }

        public int getColorDigiCopyImg()
        {
            return ICAR_CFG_COLORMODE_DIGITALCOPYIMG;
        }

        //image enhancement property
        const int ICAR_CFG_ENHANCEMENT_DOCIMAGE = 15;
        const int ICAR_CFG_ENHANCEMENT_PHOTOIMAGE = 16;
        const int ICAR_CFG_ENHANCEENT_SIGNATUREIMAGE = 17;
        const int ICAR_CFG_ENHANCEMENT_FINGERPRINTIMAGE = 18;
        const int ICAR_CFG_ENHANCEMENT_DIGITALCOPY = 19;

        public int getEnhanceDocImg()
        {
            return ICAR_CFG_ENHANCEMENT_DOCIMAGE;
        }

        public int getEnhancePhotoImg()
        {
            return ICAR_CFG_ENHANCEMENT_PHOTOIMAGE;
        }

        public int getEnhanceSigImg()
        {
            return ICAR_CFG_ENHANCEENT_SIGNATUREIMAGE;
        }

        public int getEnhanceFingerImg()
        {
            return ICAR_CFG_ENHANCEMENT_FINGERPRINTIMAGE;
        }

        public int getEnhanceDigiCopy()
        {
            return ICAR_CFG_ENHANCEMENT_DIGITALCOPY;
        }

        //device specifications
        const int ICAR_ACQ_DEVICE = 20;
        const int ICAR_ACQ_DEVICENAME = 21;


        public int getDevice()
        {
            return ICAR_ACQ_DEVICE;
        }

        public int getDeviceName()
        {
            return ICAR_ACQ_DEVICENAME;
        }

        //saving paths
        const int ICAR_ACQ_IMAGEFILEPATH = 22;
        const int ICAR_ACQ_DIRECTORYPATH = 23;

        public int getImgPath()
        {
            return ICAR_ACQ_IMAGEFILEPATH;
        }

        public int getDirctPath()
        {
            return ICAR_ACQ_DIRECTORYPATH;
        }

        //file delete setting
        const int ICAR_ACQ_DELFILEIMAGEAFTERPROCESS = 24;

        public int getDeleteFileProcess()
        {
            return ICAR_ACQ_DELFILEIMAGEAFTERPROCESS;
        }

        //result processing path
        const int ICAR_RESULT_PATH_DOCIMAGE = 26;
        const int ICAR_RESULT_PATH_PHOTOIMAGE = 27;
        const int ICAR_RESULT_PATH_SIGNATUREIMAGE = 28;
        const int ICAR_RESULT_PATH_FINGERPRINT = 29;
        const int ICAR_RESULT_PATH_DIGITALCOPYIMAGE = 30;

        public int getPathDocImage()
        {
            return ICAR_RESULT_PATH_DOCIMAGE;
        }


        public int getPathPhotoImg()
        {
            return ICAR_RESULT_PATH_PHOTOIMAGE;
        }

        public int getPathSigImg()
        {
            return ICAR_RESULT_PATH_SIGNATUREIMAGE;
        }

        public int getPathFingerImg()
        {
            return ICAR_RESULT_PATH_FINGERPRINT;
        }

        public int getPathDigitalImg()
        {
            return ICAR_RESULT_PATH_DIGITALCOPYIMAGE;
        }

        //digital copy setup
        const int ICAR_DCOPY_WIDTH = 31;
        const int ICAR_DCOPY_HEIGHT = 32;

        public int getDigiCopyHeight()
        {
            return ICAR_DCOPY_HEIGHT;
        }

        public int getDigiCopyWidth()
        {
            return ICAR_DCOPY_WIDTH;
        }

        //result xml save path
        const int ICAR_RESULT_XMLFILEPATH = 33;

        public int getXMLPath()
        {
            return ICAR_RESULT_XMLFILEPATH;
        }

        //twain setup
        const int ICAR_ACQ_TWAIN_ACQSIZEX = 34;
        const int ICAR_ACQ_TWAIN_ACQSIZEY = 35;
        const int ICAR_ACQ_TWAIN_FULLDUPLEXENABLED = 36;
        const int ICAR_ACQ_TWAIN_SIDESTOSCNA = 37;
        const int ICAR_ACQ_TWAIN_RESOLUTION = 38;
        const int ICAR_ACQ_TWAIN_COLORMODE = 39;

        public int getTwainSizeX()
        {
            return ICAR_ACQ_TWAIN_ACQSIZEX;
        }

        public int getTwainSizeY()
        {
            return ICAR_ACQ_TWAIN_ACQSIZEY;
        }

        public int getTwainFullDuplex()
        {
            return ICAR_ACQ_TWAIN_FULLDUPLEXENABLED;
        }

        public int getTwainSidesToScan()
        {
            return ICAR_ACQ_TWAIN_SIDESTOSCNA;
        }

        public int getTwainResolution()
        {
            return ICAR_ACQ_TWAIN_RESOLUTION;
        }

        public int getTwainColorMode()
        {
            return ICAR_ACQ_TWAIN_COLORMODE;
        }

        //special scan image
        const int ICAR_CFG_OUTPUT_DOC_UVIMAGE = 40;
        const int ICAR_CFG_OUTPUT_DOC_IRIMAGE = 41;
        const int ICAR_CFG_COLORMODE_DOC_UVIMAGE = 42;
        const int ICAR_CFG_COLORMODE_DOC_IRIMAGE = 43;

        public int getOutputUVImage()
        {
            return ICAR_CFG_OUTPUT_DOC_UVIMAGE;
        }

        public int getOutputIRImage()
        {
            return ICAR_CFG_OUTPUT_DOC_IRIMAGE;
        }

        public int getColorModeIR()
        {
            return ICAR_CFG_COLORMODE_DOC_IRIMAGE;
        }

        public int getColorModerUV()
        {
            return ICAR_CFG_COLORMODE_DOC_UVIMAGE;
        }

        //document special enhancement
        const int ICAR_CFG_ENHANCEMENT_DOC_UVIMAGE = 44;
        const int ICAR_CFG_ENHANCEMENT_DOC_IRIMAGE = 45;

        public int getEnhanceDocCopyUV()
        {
            return ICAR_CFG_ENHANCEMENT_DOC_UVIMAGE;
        }

        public int getEnhanceDocCopyIR()
        {
            return ICAR_CFG_ENHANCEMENT_DOC_IRIMAGE;
        }

        //special scan path
        const int ICAR_RESULT_PATH_DOC_UVIMAGE = 46;
        const int ICAR_RESULT_PATH_DOC_IRIMAGE = 47;

        public int getIRImagePath()
        {
            return ICAR_CFG_COLORMODE_DIGITALCOPY_PATH_IRIMAGE;
        }

        public int getUVImagePath()
        {
            return ICAR_CFG_COLORMODE_DIGITALCOPY_PATH_UVIMAGE;
        }

        //special scan digital copy path
        const int ICAR_CFG_OUTPUT_DIGITALCOPY_UVIMAGERES = 48;
        const int ICAR_CFG_OUTPUT_DIGITALCOPY_IRIMAGERES = 49;
        const int ICAR_CFG_COLORMODE_DIGITALCOPY_PATH_UVIMAGE = 50;
        const int ICAR_CFG_COLORMODE_DIGITALCOPY_PATH_IRIMAGE = 51;

        public int getDigitalUVImage()
        {
            return ICAR_CFG_ENHANCEMENT_DIGITALCOPY_UVIMAGE;
        }

        public int getDigitalIRImage()
        {
            return ICAR_CFG_ENHANCEMENT_DIGITALCOPY_IRIMAGE;
        }

        public int getPathDigitalColorUV()
        {
            return ICAR_CFG_COLORMODE_DIGITALCOPY_PATH_UVIMAGE;
        }

        public int getPathDigitalColorIR()
        {
            return ICAR_CFG_COLORMODE_DIGITALCOPY_PATH_IRIMAGE;
        }

        //special scna enhancement
        const int ICAR_CFG_ENHANCEMENT_DIGITALCOPY_UVIMAGE = 52;
        const int ICAR_CFG_ENHANCEMENT_DIGITALCOPY_IRIMAGE = 53;

        public int getEnhanceDigiCopyUV()
        {
            return ICAR_CFG_ENHANCEMENT_DIGITALCOPY_UVIMAGE;
        }

        public int getEnhanceDigiCopyIR()
        {
            return ICAR_CFG_ENHANCEMENT_DIGITALCOPY_IRIMAGE;
        }

        //special scan path
        const int ICAR_RESULT_PATH_DIGITALCOPY_UVIMAGE = 54;
        const int ICAR_RESULT_PATH_DIGITALCOPY_IRIMAGE = 55;

        public int getPathDigiCopyUV()
        {
            return ICAR_RESULT_PATH_DIGITALCOPY_UVIMAGE;
        }

        public int getPathDigiCopyIR()
        {
            return ICAR_RESULT_PATH_DIGITALCOPY_IRIMAGE;
        }

        //enable special scan
        const int ICAR_ACQ_ENABLE_VISIBLE_LIGHTING = 56;
        const int ICAR_ACQ_ENABLE_UV_LIGHTING = 57;
        const int ICAR_ACQ_ENABLE_IR_LIGHTING = 58;

        public int getVisibleLight()
        {
            return ICAR_ACQ_ENABLE_VISIBLE_LIGHTING;
        }

        public int getUVLight()
        {
            return ICAR_ACQ_ENABLE_UV_LIGHTING;
        }

        public int getIRLight()
        {
            return ICAR_ACQ_ENABLE_IR_LIGHTING;
        }

        //input image resolution
        const int ICAR_CFG_INPUT_DOC_XRESOLUTION = 65;
        const int ICAR_CFG_INPUT_DOC_YRESOLUTION = 66;

        public int getYResolution()
        {
            return ICAR_CFG_INPUT_DOC_YRESOLUTION;
        }

        public int getXResolution()
        {
            return ICAR_CFG_INPUT_DOC_XRESOLUTION;
        }

        //RFID  device
        const int ICAR_RFID_DEVICE = 71;

        public int getRFIDDevice()
        {
            return ICAR_RFID_DEVICE;
        }

        //rfid image path
        const int ICAR_RESULT_PATH_RFID_PHOTOIMAGE = 73;

        public int getPathRFIDPhotoImg()
        {
            return ICAR_RESULT_PATH_RFID_PHOTOIMAGE;
        }

        //SC device
        const int ICAR_SC_DEVICE = 86;

        public int getSCDevice()
        {
            return ICAR_SC_DEVICE;
        }

        //images
        const int ICAR_ACQ_ALL_IMAGES = 129;
        const int ICAR_ACQ_SAVE_IMAGES = 130;

        public int getAllImg()
        {
            return ICAR_ACQ_ALL_IMAGES;
        }

        public int getSaveImg()
        {
            return ICAR_ACQ_SAVE_IMAGES;
        }

    }
}