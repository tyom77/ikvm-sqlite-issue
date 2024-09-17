package com.asukiasyan.poc;

import com.asukiasyan.poc.service.SQliteService;

public class Main {
    public static void main(String[] args) {
        System.out.println("Hello world!");
        SQliteService sQliteService = new SQliteService();
        sQliteService.init();
    }
}