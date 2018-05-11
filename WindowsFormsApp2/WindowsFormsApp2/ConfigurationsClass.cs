using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICARCOMLib;
using IcarConstants;

namespace WindowsFormsApp2
{
    class ConfigurationClass
    {
        public IcarConstants.IcarConstants icarConstants;

        public ConfigurationClass(IcarConstants.IcarConstants icarConstants)
        {
            this.icarConstants = icarConstants;
        }

        public void runConfigs(ICAR icar)
        {
            icar.setPropertyString(icarConstants.getDeviceName(), ""); //device name
            icar.checkError();
            icar.setPropertyString(icarConstants.getImgPath(), "");
            icar.checkError();
            icar.setPropertyString(icarConstants.getDirctPath(), " ");
            icar.checkError();


            icar.setPropertyNumber(icarConstants.getDevice(), icarConstants.getIDBox());

            icar.checkError();

            icar.setPropertyNumber(icarConstants.getRFIDDevice(), 3);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getSCdevice(), 1);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getUVLight(), 1);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getIRLight(), 1);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getImageMerging(), 5);
            icar.checkError();

            icar.setPropertyNumber(icarConstants.getDateFormat(), 3);

            icar.checkError();


            icar.setPropertyNumber(icarConstants.getUpperCase(), 1);

            icar.setPropertyNumber(icarConstants.getRemoveAccents(), 0);

            icar.checkError();


            icar.setPropertyNumber(icarConstants.getDeleteFileProcess(), 0);

            icar.checkError();

            icar.setPropertyNumber(icarConstants.getProcessMode(), 0);

            icar.checkError();

            icar.setPropertyNumber(icarConstants.getDigiCopyHeight(), 86);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getDigiCopyWidth(), 55);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getPathDocImage(), 200);
            icar.checkError();



            icar.checkError();

            icar.setPropertyNumber(icarConstants.getPathSigImg(), 200);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getPathFingerImg(), 200);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getOutputUVImage(), 200);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getOutputIRImage(), 200);
            icar.checkError();


            icar.setPropertyNumber(icarConstants.getColorDocIMG(), 1);

            icar.checkError();


            icar.setPropertyNumber(icarConstants.getColorPhotoImg(), 1);


            icar.checkError();


            icar.setPropertyNumber(icarConstants.getColorSigImg(), 1);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getColorFingerPrintImg(), 1);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getColorModerUV(), 1);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getColorModeIR(), 1);
            icar.checkError();


            icar.setPropertyNumber(icarConstants.getEnhanceDocImg(), 0);

            icar.checkError();


            icar.setPropertyNumber(icarConstants.getEnhancePhotoImg(), 0);

            icar.checkError();


            icar.setPropertyNumber(icarConstants.getEnhanceSigImg(), 1);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getEnhanceFingerImg(), 1);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getEnhanceDocCopyUV(), 1);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getEnhanceDocCopyIR(), 1);
            icar.checkError();

            icar.setPropertyString(icarConstants.getPathRFIDPhotoImg(), "");
            icar.checkError();
            icar.setPropertyString(icarConstants.getPathDocImage(), "");
            icar.checkError();
            icar.setPropertyString(icarConstants.getPathSigImg(), "");
            icar.checkError();
            icar.setPropertyString(icarConstants.getPathFingerImg(), "");
            icar.checkError();
            icar.setPropertyString(icarConstants.getPathDigitalImg(), "");
            icar.checkError();
            icar.setPropertyString(icarConstants.getUVImagePath(), "");
            icar.checkError();
            icar.setPropertyString(icarConstants.getIRImagePath(), "");
            icar.checkError();
            icar.setPropertyString(icarConstants.getXMLPath(), "");
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getTwainSizeX(), 175);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getTwainSizeY(), 111);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getColorPhotoImg(), 0);

            icar.checkError();
        }

        public void setDefault(ICAR icar)
        {
            String path = Directory.GetCurrentDirectory() + @"\bin\image.bmp";
            icar.checkError();
            icar.setPropertyString(icarConstants.getDeviceName(), ""); //device name
            icar.checkError();
            icar.setPropertyString(icarConstants.getImgPath(), path); //image path
            icar.checkError();
            icar.setPropertyString(icarConstants.getDirctPath(), path); //
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getDevice(), 25); //device type
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getRFIDDevice(), 3); //RFID Device
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getSCdevice(), 1);    //SmartCard Device  
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getUVLight(), 1);     //UV Light Y or N
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getIRLight(), 1);     //IR Light Y or N
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getImageMerging(), 5);   //Merge front and back 
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getDateFormat(), 0);      //Date Format
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getUpperCase(), 1);       //UpperCase
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getRemoveAccents(), 1);   //with Accents
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getDeleteFileProcess(), 0);   //delete file after process
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getProcessMode(), 0);         //how process
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getDigiCopyWidth(), 55);      //width digital copy
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getDigiCopyHeight(), 86);      //height Digital Copy
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getPathDocImage(), 200);      //doc Image path   
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getPathPhotoImg(), 200);      //photo path
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getPathSigImg(), 200);        //signature path
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getPathFingerImg(), 200);     //finger path
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getColorDocIMG(), 1);         //doc color
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getColorPhotoImg(), 1);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getColorSigImg(), 1);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getColorFingerPrintImg(), 1);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getColorModerUV(), 1);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getColorModeIR(), 1);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getEnhanceDocImg(), 1);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getEnhancePhotoImg(), 1);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getEnhanceSigImg(), 1);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getEnhanceFingerImg(), 1);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getEnhanceDocCopyUV(), 1);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getEnhanceDocCopyIR(), 1);
            icar.checkError();
            icar.setPropertyString(icarConstants.getPathPhotoImg(), path + @"/photoTemp.jpg");
            icar.checkError();
            icar.setPropertyString(icarConstants.getPathRFIDPhotoImg(), path + @"/RFIDTemp.jpg");
            icar.checkError();
            icar.setPropertyString(icarConstants.getPathDocImage(), path + @"/docTemp.jpg");
            icar.checkError();
            icar.setPropertyString(icarConstants.getPathSigImg(), path + @"/signTemp.jpg");
            icar.checkError();
            icar.setPropertyString(icarConstants.getPathFingerImg(), path + @"/fngrTemp.jpg");
            icar.checkError();
            icar.setPropertyString(icarConstants.getPathDigitalImg(), path + @"/digiTemp.jpg");
            icar.checkError();
            icar.setPropertyString(icarConstants.getUVImagePath(), path + @"/uvTemp.jpg");
            icar.checkError();
            icar.setPropertyString(icarConstants.getIRImagePath(), path + @"/irTemp.jpg");
            icar.checkError();
            icar.setPropertyString(icarConstants.getXMLPath(), path + @"/Output.XML");
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getTwainSizeX(), 175);
            icar.checkError();
            icar.setPropertyNumber(icarConstants.getTwainSizeY(), 111);
            icar.checkError();
        }
    }
}
