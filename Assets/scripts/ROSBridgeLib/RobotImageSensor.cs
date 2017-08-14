using ROSBridgeLib;
using ROSBridgeLib.sensor_msgs;
using ROSBridgeLib.std_msgs;
using ROSBridgeLib.turtlesim;
using System.Collections;
using SimpleJSON;
using UnityEngine;

/**
 * This is a toy example of the Unity-ROS interface talking to the TurtleSim 
 * tutorial (circa Groovy). Note that due to some changes since then this will have
 * to be slightly re-written, but as its a test ....
 * 
 * This defines the callback that links the color_sensor message and its callback
 * 
 * @author Michael Jenkin, Robert Codd-Downey and Andrew Speers
 * @version 3.0
 **/

public class RobotImageSensor : ROSBridgeSubscriber {
	
	public new static string GetMessageTopic() {
<<<<<<< HEAD

        return "/iRobot/camera/image_raw/compressed";
        
        //for bag file
        //return "/camera/compressed";

        
=======
        // return "/iRobot/camera/image_raw/compressed";
        return "/camera/compressed";
>>>>>>> 792e70ef7862b7f8d611ae04c31c3c0aad17fc74
    }  
	
	public new static string GetMessageType() {
		return "sensor_msgs/CompressedImage";
	}
	
	public new static ROSBridgeMsg ParseMessage(JSONNode msg) {
        return new CompressedImageMsg(msg);
	}
	
	public new static void CallBack(ROSBridgeMsg msg) {
        CompressedImageMsg imgMsg = msg as CompressedImageMsg;
        ROSManager.getInstance().getUBDCam().LoadImage(imgMsg.GetImage());
    }
}
