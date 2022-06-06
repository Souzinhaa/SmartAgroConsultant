import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdubacaoComponent } from './adubacao.component';

describe('AdubacaoComponent', () => {
  let component: AdubacaoComponent;
  let fixture: ComponentFixture<AdubacaoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdubacaoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdubacaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
