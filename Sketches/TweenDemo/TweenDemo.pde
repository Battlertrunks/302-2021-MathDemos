
float valStart = 0;
float valEnd = 500;

float animLength = 1;
float animPlayheadTime = 0;
boolean isTweenPlaying = false;

float previousTimestamp = 0;

void setup(){
  size(500, 500);
}

void draw() {
  
   background(128); // Fill screen with 50% gray
   
   float currentTimestamp = millis() / 1000.0; 
   float dt = currentTimestamp - previousTimestamp;
   previousTimestamp = currentTimestamp;
   
   // Move playhead forward in time
   if(isTweenPlaying) {
   animPlayheadTime += dt;
     // Stop playing at end of tween
     if(animPlayheadTime > animLength) {
       isTweenPlaying = false;
       animPlayheadTime = animLength;
     }
   }
   
  // Percent:
  float p = animPlayheadTime / animLength;
  
  // Manipulate 'p'
  //p = p * p; // "Bends" curve down - Ease in
  //p = 1 - p;
  //p = 1 - pow(1 - p, 2); // or 1 - (1 - p) * (1 - p) "Bends" curve up -  Ease out
  p = p * p * (3 - 2 * p); // smooth-step
  
  float x = lerp(valStart, valEnd, p);
  ellipse(x, height/2.0, 20, 20);
  
  
  
}

void mousePressed() {
  animPlayheadTime = 0; //retarts animation to 0
  isTweenPlaying = true;
}
