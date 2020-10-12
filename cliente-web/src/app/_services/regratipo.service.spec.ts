/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { RegratipoService } from './regratipo.service';

describe('Service: Regratipo', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [RegratipoService]
    });
  });

  it('should ...', inject([RegratipoService], (service: RegratipoService) => {
    expect(service).toBeTruthy();
  }));
});
