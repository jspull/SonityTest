// Created by Victor Engstr�m
// Copyright 2024 Sonigon AB
// http://www.sonity.org/

//using UnityEngine;

//namespace Sonity.Internal {

//    public class SoundEventInstanceVirtualVoice { // Virtualize Todo

//        public SoundEventPlayTypeInstance playTypeInstance = new SoundEventPlayTypeInstance();

//        public void Assign(VoiceParameterInstance voiceParameter, SoundEventPlayType playType, Transform instanceIDTransform, Vector3? positionVector3, Transform positionTransform, SoundContainerBase soundContainer, SoundEventBase soundEvent) {
//            assinged = true;
//            this.voiceParameter.CopyTo(voiceParameter);
//            this.voiceParameter.CheckIfSoundParametersCanChangeVolume(soundContainer);
//            this.voiceParameter.CheckIfSoundParameterHasContinuousIntensity();

//            playTypeInstance.SetValues(playType, instanceIDTransform, positionVector3, positionTransform, soundContainer, soundEvent);
//        }

//        public void ResetAssigned() {
//            assinged = false;
//        }

//        public bool assinged = false;

//        public VoiceParameterInstance voiceParameter = new VoiceParameterInstance();

//        public float maxRange;
//    }
//}