import React, { useCallback, useState } from 'react';
import { AiOutlineAudio, AiFillAudio } from 'react-icons/ai';
import { AudioRecorderService } from './AudioRecorderService';

const iconsSize = "2em";
const recorder = new AudioRecorderService();

function _audioRecorder({ onRecordingFinished }) {
  const [isRecording, setIsRecording] = useState(false);

  const onRecorderClick = useCallback(async () => {
    if (!isRecording) {
      await recorder.start();
    } else {
      const blob = recorder.stop();
      onRecordingFinished(blob);
    }

    setIsRecording(!isRecording)
  }, [isRecording]);

  return (
    <span onClick={onRecorderClick} style={{ cursor: "pointer" }}>
      {isRecording ? <AiFillAudio size={iconsSize} /> : <AiOutlineAudio size={iconsSize} />}
    </span>
  );
}

export const AudioRecorder = React.memo(_audioRecorder);