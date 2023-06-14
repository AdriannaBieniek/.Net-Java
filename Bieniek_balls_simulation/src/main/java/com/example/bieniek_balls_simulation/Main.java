package com.example.bieniek_balls_simulation;
import javafx.application.Application;
import javafx.stage.Stage;

public class Main extends Application {
    @Override
    public void start(Stage stage) throws InterruptedException {
        Ball[] ball= new Ball[5];
        for(int i=0;i<5;i++)
        {
            ball[i]=new Ball((i+1)*30,(i+1)*30,(i+1)*10,3.5);
        }

        int screen_width=800;
        int screen_height=600;
        Stage primaryStage = new Stage();
        Drawing draw= new Drawing();
        int n=2;
        draw.start(primaryStage,ball[n].x,ball[n].y,ball[n].radius,screen_width,screen_height,ball[n].speed);
    }

    public static void main(String[] args) {
        launch();
    }
}
