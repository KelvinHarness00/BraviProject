import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-contacts',
  templateUrl: './contacts.component.html',
  styleUrls: ['./contacts.component.css']
})
export class ContactsComponent implements OnInit {

  title = 'Contacts';

  public contacts =[
    {name: 'Maria'},
    {name: 'Bruna'},
    {name: 'Ramon'},
    {name: 'Kelvin'},
    {name: 'Sophia'},
    {name: 'Bottas'},
  ]

  constructor() { }

  ngOnInit() {
  }

}
