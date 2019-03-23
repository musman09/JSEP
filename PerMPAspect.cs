SYNTAXDEF PerMPAspect
FOR <http://www.emftext.org/language/PerMPAspect>
START Aspect
TOKENS {
	DEFINE ASPECTEXTENSION $'StateMachine'|'Class'$; 
	DEFINE EXTENSION $'Behavior'|'Transition'|'Operation'$;
	DEFINE SELECTIONTYPE $'All'|'One'|'Subset'$;
	DEFINE DATASIZEUNITKIND $'bits'|'Bytes'|'KB'|'MB'|'GB'$; 
	DEFINE TIMEUNITKIND $'s'|'tick'|'ms'|'us'|'min'|'hrs'|'dys'$; 
	DEFINE NETWORKKIND $'WIFI'|'G3'|'G4'$;
	DEFINE CAMERASIDE $'Front'|'Back'$;
	DEFINE MOBILEENERGYUNITKIND $'W'|'mW'|'KW'|'J'|'kJ'|'Wh'|'kWh'|'mWh'|'mAh'|'Percentage'$;
	DEFINE MEDIATYPE $'Image'$;
	DEFINE MUSICTYPE $'Audio'|'Video'$;
	DEFINE RADIOTYPE $'AM'|'FM'$;
	DEFINE MESSAGETYPE $'SMS'|'MMS'$;
	DEFINE SERVICETYPE $'Background'|'Foreground'$;
}
RULES {
	Aspect ::= "Aspect" "appliesTo="apply[ASPECTEXTENSION] !1 #4 "whereBase="base['"','"'] " {" !1 #1 pointcut+ !0 "}" ;
	Pointcut ::= "Pointcut" name[] #1 !1 #6 "whereType="type[SELECTIONTYPE] #1 "selectionConstraint="selectionConstraint['"','"'] 
				" {" advice? advice? advice? introduction? joinpoints+ !0 "};" ;
	After ::= !1 #5 "AfterAdvice" name[] " {" !1 #7 processingTime? memory? energy? network? gps? bluetooth? camera? call? gallery? 
					contact? musicPlayer? ringtone? reminder? volumeController? notification? radio? message? service? database?  
					external? internalMemory? !0 #5 "};" ;
	Before ::= !1 #5 "BeforeAdvice" name[] " {" !1 #7 processingTime? memory? energy? network? gps? bluetooth? camera? call? gallery? 
					contact? musicPlayer? ringtone? reminder? volumeController? notification? radio? message? service? database?  
					external? internalMemory? !0 #5 "};" ;
	Around ::= !1 #5 "AroundAdvice" name[] " {" !1 #7 processingTime? memory? energy? network? gps? bluetooth? camera? call? gallery? 
					contact? musicPlayer? ringtone? reminder? volumeController? notification? radio? message? service? database?  
					external? internalMemory? !0 #5 "};" ;
	Introduction ::= !1 #5 "Introduction" name[] " {" !1 #7 "introduce="introduce[EXTENSION] !1 #9 "value="value['"','"'] !0 #5 "};" ;
	Joinpoint ::= !1 #5 "Joinpoint" " {" !1 #7 "joinAt="joinAt[EXTENSION] !0 #5 "};" ;
	Time ::= !1 #5 "Time" " {" "value="value[] "unit="unit[TIMEUNITKIND] "} ;" ;
	ProcessingTime ::= "ProcessingTime" "{" "minTimeAllowed=" minTimeAllowed? ", maxTimeAllowed=" maxTimeAllowed? 
												", acceptableJitter=" acceptableJitter? "};" ;
	Memory ::= !1 #5 "Memory" " {" "value="value[] "unit="unit[DATASIZEUNITKIND] "} ;" ;						
	MemoryConsumed ::= "MemoryConsumed" "{" "minMemoryAllowed=" minMemoryAllowed? ", maxMemoryAllowed=" maxMemoryAllowed? 
												", acceptableDelta=" acceptableDelta? "};" ;
	Energy ::= !1 #5 "Energy" " {" "value="value[] "unit="unit[MOBILEENERGYUNITKIND] "} ;" ;
	EnergyConsumed ::= "EnergyConsumed" "{" "minEnergyAllowed=" minEnergyAllowed? ", maxEnergyAllowed=" maxEnergyAllowed? 
												", acceptableDelta=" acceptableDelta? "};" ;
	BluetoothPerformance ::= "Bluetooth" "{" "connectionTime=" connectionTime? ", transferTime=" transferTime? 
												", memoryConsumed=" memoryConsumed?  ", energyConsumed=" energyConsumed "};" ;
	ExternalMemoryPerformance ::= "ExternalMemory" "{" "selectionTime=" selectionTime? ", openTime=" openTime? ", saveTime=" saveTime?
												", memoryConsumed=" memoryConsumed  ", energyConsumed=" energyConsumed "};" ;
	ContactPerformance ::= "Contact" "{" "additionTime=" additionTime? ", updationTime=" updationTime? ", selectionTime=" selectionTime?
												", memoryConsumed=" memoryConsumed  ", energyConsumed=" energyConsumed "};" ;
	ReminderPerformance ::= "Reminder" "{" "notifyTime=" notifyTime ", memoryConsumed=" memoryConsumed? ", energyConsumed=" energyConsumed "};" ;
	VolumeControllerPerformance ::= "VolumeController" "{" "decreaseTime=" decreaseTime? ", increaseTime=" increaseTime?
												", memoryConsumed=" memoryConsumed?  ", energyConsumed=" energyConsumed "};" ;
	NetworkPerformance ::= "Network" "{" "networkKind=" networkKind[NETWORKKIND] ", responseTime=" responseTime? ", uploadTime=" uploadTime? ", downloadTime=" downloadTime?
												", memoryConsumed=" memoryConsumed? ", energyConsumed=" energyConsumed "};" ;
	GPSPerformance ::= "GPS" "{" "locationFinderTime=" locationFinderTime? ", connectionTime=" connectionTime?
												", memoryConsumed=" memoryConsumed?  ", energyConsumed=" energyConsumed "};" ;
	CameraPerformance ::= "Camera" "{" "cameraSide=" cameraSide[CAMERASIDE] ", switchOnTime=" swtichOnTime? ", captureTime=" captureTime? ", saveTime=" saveTime?
												", memoryConsumed=" memoryConsumed  ", energyConsumed=" energyConsumed "};" ;
	CallPerformance ::= "Call" "{" "dialTime=" dialTime? ", recieveTime=" recieveTime?
												", memoryConsumed=" memoryConsumed? ", energyConsumed=" energyConsumed "};" ;
	GalleryPerformance ::= "Gallery" "{" "mediaType=" mediaType[MEDIATYPE] ", openTime=" openTime? ", selectionTime=" selectionTime?
												", memoryConsumed=" memoryConsumed  ", energyConsumed=" energyConsumed "};" ;
	MusicPlayerPerformance ::= "MusicPlayer" "{" "musicType=" musicType[MUSICTYPE] ", playTime=" playTime? ", selectionTime=" selectionTime?
												", memoryConsumed=" memoryConsumed ", energyConsumed=" energyConsumed "};" ;
	RingtonePerformance ::= "Ringtone" "{" "ringTime=" ringTime? ", selectionTime=" selectionTime?
												", memoryConsumed=" memoryConsumed?  ", energyConsumed=" energyConsumed "};" ;
	NotificationPerformance ::= "Notification" "{" "notificationTime=" notificationTime 
												", memoryConsumed=" memoryConsumed  ", energyConsumed=" energyConsumed "};" ;
	RadioPerformance ::= "Radio" "{" "radioType=" radioType[RADIOTYPE] ", connectionTime=" connectionTime? ", playTime=" playTime?
												", memoryConsumed=" memoryConsumed?  ", energyConsumed=" energyConsumed "};" ;
	MessagePerformance ::= "Message" "{" "messageType=" messageType[MESSAGETYPE] ", creationTime=" creationTime? ", sendTime=" sendTime?
												", memoryConsumed=" memoryConsumed  ", energyConsumed=" energyConsumed "};" ;
	ServicePerformance ::= "Service" "{" "serviceType=" serviceType[SERVICETYPE] ", executionTime=" executionTime? ", shiftTime=" shiftTime?
												", memoryConsumed=" memoryConsumed  ", energyConsumed=" energyConsumed "};" ;
	DatabasePerformance ::= "Database" "{" "insertionTime=" insertionTime? ", deletionTime=" deletionTime? ", updationTime=" updationTime? ", selectionTime=" selectionTime?
												", memoryConsumed=" memoryConsumed  ", energyConsumed=" energyConsumed "};" ;
	InternalMemoryPerformance ::= "InternalMemory" "{" "openTime=" openTime? ", saveTime=" saveTime? ", selectionTime=" selectionTime?
												", memoryConsumed=" memoryConsumed  ", energyConsumed=" energyConsumed "};" ;
}